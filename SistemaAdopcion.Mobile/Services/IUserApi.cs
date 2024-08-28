using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAdopcion.Mobile.Services
{
    [Headers("Authorization: Bearer")]
    public interface IUserApi
    {
        [Post("/api/user/adopt/{petId}")]
        Task<ApiResponse> AdoptPetAsync(int petId);

        [Get("/api/user/adoptions")]
        Task<SisemaAdopcion.Shared.Dtos.ApiResponse<PetListDto[]>> GetUserAdoptionsAsync();

        [Get("/api/user/favorites")]
        Task<SisemaAdopcion.Shared.Dtos.ApiResponse<PetListDto[]>> GetUserFavoritesAsync();

        [Post("/api/user/favorites/{petId}")]
        Task<ApiResponse> ToggleFavoritesAsync(int petId);

        [Get("/api/user/view-pet-details/{petId}")]
        Task<SisemaAdopcion.Shared.Dtos.ApiResponse<PetDetailDto>> GetPetDetailsAsync(int petId);

        [Post("/api/user/change-password")]
        Task<ApiResponse> ChangePasswordAsync(SingleValueDto<string> newPassword);
    }
}
