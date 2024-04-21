using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Service.Interfaces;

namespace Infrastructure
{
    public class JwtTokenValidationMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IServiceScopeFactory _serviceScopeFactory;

        public JwtTokenValidationMiddleware(RequestDelegate next, IServiceScopeFactory serviceScopeFactory)
        {
            _next = next;
            _serviceScopeFactory = serviceScopeFactory;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Path.Value.EndsWith("/Login", StringComparison.OrdinalIgnoreCase))
            {
                await _next(context);
                return;
            }

            using var scope = _serviceScopeFactory.CreateScope();

            var usuarioService = scope.ServiceProvider.GetRequiredService<IUsuarioService>();

            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            var valid = await usuarioService.TokenIsValid(token);

            if (string.IsNullOrEmpty(token) || !valid)
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("Unauthorized");
            }
            await _next(context);
        }
    }

}
