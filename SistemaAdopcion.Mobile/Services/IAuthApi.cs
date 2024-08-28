using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SisemaAdopcion.Shared.Dtos;

namespace SistemaAdopcion.Mobile.Services
{
    public interface IAuthApi
    {
        [Post("/api/auth/login")]
        Task<SisemaAdopcion.Shared.Dtos.ApiResponse<AuthResponseDto>> LoginAsync(LoginRequestDto dto);

        [Post("/api/auth/register")]
        Task<SisemaAdopcion.Shared.Dtos.ApiResponse<AuthResponseDto>> RegisterAsync(RegisterRequestDto dto);
    }
}
