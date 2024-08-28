using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAdopcion.Mobile.Services
{
    public interface IPetsApi
    {
        [Get("/api/pets")]
        Task<SisemaAdopcion.Shared.Dtos.ApiResponse<PetListDto[]>> GetAllPetsAsync();

        [Get("/api/pets/new/{count}")]
        Task<SisemaAdopcion.Shared.Dtos.ApiResponse<PetListDto[]>> GetNewlyAddedPetsAsync(int count);

        [Get("/api/pets/popular/{count}")]
        Task<SisemaAdopcion.Shared.Dtos.ApiResponse<PetListDto[]>> GetPopularPetsAsync(int count);

        [Get("/api/pets/random/{count}")]
        Task<SisemaAdopcion.Shared.Dtos.ApiResponse<PetListDto[]>> GetRandomPetsAsync(int count);

        [Get("/api/pets/{petId}")]
        Task<SisemaAdopcion.Shared.Dtos.ApiResponse<PetDetailDto>> GetPetDetailsAsync(int petId);
    }
}
