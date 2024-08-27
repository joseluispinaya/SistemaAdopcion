using SisemaAdopcion.Shared.Dtos;

namespace SistemaAdopcion.Api.Services
{
    public interface IPetService
    {
        Task<ApiResponse<PetListDto[]>> GetAllPetsAsync();
        Task<ApiResponse<PetListDto[]>> GetNewlyAddedPetsAsync(int count);
        Task<ApiResponse<PetDetailDto>> GetPetDetailsAsync(int petId, int userId = 0);
        Task<ApiResponse<PetListDto[]>> GetPopularPetsAsync(int count);
        Task<ApiResponse<PetListDto[]>> GetRandomPetsAsync(int count);
    }
}
