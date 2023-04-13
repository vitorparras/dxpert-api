using Domain.DTO.Request;
using Domain.DTO.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

namespace dxpert_api.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var token = await _usuarioService.LoginAsync(request.Email, request.Senha);

            if (string.IsNullOrEmpty(token))
            {
                return Unauthorized("Usuário ou senha inválidos");
            }

            return Ok(new LoginResponse { Token = token });
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            if (Request.Headers.TryGetValue("Authorization", out var authorizationHeader))
            {
                var token = authorizationHeader.ToString().Replace("Bearer ", string.Empty);
                await _usuarioService.LogoutAsync(token);

                return NoContent();
            }

            return BadRequest("Token não encontrado no cabeçalho 'Authorization'.");
        }
    }
}
