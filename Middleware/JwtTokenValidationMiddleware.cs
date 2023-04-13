using Microsoft.AspNetCore.Http;
using Service.Interfaces;

namespace Middleware
{
    public class JwtTokenValidationMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IUsuarioService _usuarioService;

        public JwtTokenValidationMiddleware(RequestDelegate next, IUsuarioService usuarioService)
        {
            _next = next;
            _usuarioService = usuarioService;
        }

        public async Task Invoke(HttpContext context)
        {
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            var valid = await _usuarioService.TokenIsValid(token);

            if (!string.IsNullOrEmpty(token) && valid)
            {
                await _next(context);
            }
            else
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("Unauthorized");
            }
        }
    }

}
