using Microsoft.EntityFrameworkCore;
using SisemaAdopcion.Shared.Dtos;
using SisemaAdopcion.Shared.Enumerations;
using SistemaAdopcion.Api.Data;
using SistemaAdopcion.Api.Data.Entities;
using SistemaAdopcion.Api.Extensions;

namespace SistemaAdopcion.Api.Services
{
    public class UserPetService : IUserPetService
    {
        private static readonly SemaphoreSlim _semaphore = new(1, 1);
        private readonly PetContext _context;

        public UserPetService(PetContext context)
        {
            _context = context;
        }

        public async Task<ApiResponse> ToggleFavoritesAsync(int userId, int petId)
        {
            var userFavorite = await _context.UserFavorites
                                    .FirstOrDefaultAsync(uf => uf.UserId == userId && uf.PetId == petId);

            if (userFavorite is not null)
            {
                _context.UserFavorites.Remove(userFavorite);
            }
            else
            {
                userFavorite = new UserFavorites
                {
                    UserId = userId,
                    PetId = petId
                };
                await _context.UserFavorites.AddAsync(userFavorite);
            }
            await _context.SaveChangesAsync();

            return ApiResponse.Success();
        }
        public async Task<ApiResponse<PetListDto[]>> GetUserFavoritesAsync(int userId)
        {
            //.Select(uf => uf.Pet)
            var pets = await _context.UserFavorites
                                    .Where(uf => uf.UserId == userId)
                                    .Select(uf => uf.Pet)
                                    .Select(Selectors.PetToPetListDto!)
                                    .ToArrayAsync();

            return ApiResponse<PetListDto[]>.Success(pets);
        }

        public async Task<ApiResponse<PetListDto[]>> GetUserAdoptionsAsync(int userId)
        {
            var pets = await _context.UserAdoptions
                                    .Where(uf => uf.UserId == userId)
                                    .Select(uf => uf.Pet)
                                    .Select(Selectors.PetToPetListDto!)
                                    .ToArrayAsync();

            return ApiResponse<PetListDto[]>.Success(pets);
        }

        public async Task<ApiResponse> AdoptPetAsync(int userId, int petId)
        {
            try
            {
                await _semaphore.WaitAsync();

                var pet = await _context.Pets
                                    .AsTracking()
                                    .FirstOrDefaultAsync(p => p.Id == petId);

                if (pet is null)
                    return ApiResponse.Fail("Solicitud invalida");

                if (pet.AdoptionStatus == AdoptionStatus.Adopted)
                    return ApiResponse.Fail($"{pet.Name} ya esta adoptado.");

                pet.AdoptionStatus = AdoptionStatus.Adopted;

                var userAdoption = new UserAdoption
                {
                    UserId = userId,
                    PetId = petId
                };
                await _context.UserAdoptions.AddAsync(userAdoption);

                await _context.SaveChangesAsync();

                return ApiResponse.Success();
            }
            catch (Exception ex)
            {
                return ApiResponse.Fail($"Error al adoptar. {ex.Message}");
                //throw;
            }
            finally
            {
                _semaphore.Release();
            }
        }

    }
}
