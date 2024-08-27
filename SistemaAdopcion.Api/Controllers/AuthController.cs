﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SisemaAdopcion.Shared.Dtos;
using SistemaAdopcion.Api.Services;

namespace SistemaAdopcion.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        //  api/auth/login
        [HttpPost("login")]
        public async Task<ApiResponse<AuthResponseDto>> Login(LoginRequestDto dto) =>
            await _authService.LoginAsync(dto);

        //  api/auth/register
        [HttpPost("register")]
        public async Task<ApiResponse<AuthResponseDto>> Register(RegisterRequestDto dto) =>
            await _authService.RegisterAsync(dto);
    }
}
