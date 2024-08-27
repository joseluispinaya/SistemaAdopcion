using SisemaAdopcion.Shared.Dtos;

namespace SistemaAdopcion.Api.Services
{
    public interface IAuthService
    {
        Task<ApiResponse<AuthResponseDto>> LoginAsync(LoginRequestDto dto);
        Task<ApiResponse<AuthResponseDto>> RegisterAsync(RegisterRequestDto dto);
        Task<ApiResponse> ChangePasswordAsync(int userId, string newPassword);
    }
}
