using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Domain.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Repository.Interface;
using Service.Interfaces;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;

namespace Service
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IGenericRepository<Usuario> _usuarioRepository;
        private readonly IGenericRepository<AuthToken> _tokenRepository;
        private readonly IConfiguration _configuration;

        public UsuarioService(
            IGenericRepository<Usuario> usuarioRepository,
            IGenericRepository<AuthToken> tokenRepository,
            IConfiguration configuration)
        {
            _usuarioRepository = usuarioRepository ?? throw new ArgumentNullException(nameof(usuarioRepository));
            _tokenRepository = tokenRepository ?? throw new ArgumentNullException(nameof(tokenRepository));
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        public async Task<IEnumerable<Usuario>> GetAllAsync()
        {
            return await _usuarioRepository.GetAllAsync();
        }

        public async Task<Usuario> GetByIdAsync(int id)
        {
            return await _usuarioRepository.GetByIdAsync(id);
        }

        public async Task<Usuario> AddAsync(Usuario usuario)
        {
            await _usuarioRepository.AddAsync(usuario);
            return usuario;
        }

        public async Task UpdateAsync(Usuario usuario)
        {
            await _usuarioRepository.UpdateAsync(usuario);
        }

        public async Task DeleteAsync(int id)
        {
            var user = await GetByIdAsync(id);
            if (user != null)
            {
                await _usuarioRepository.RemoveAsync(user);
            }
        }

        public async Task<string> LoginAsync(string email, string senha)
        {
            var usuario = await _usuarioRepository
                .FirstOrDefaultAsync(x => x.Ativo 
                                && x.Email == email 
                                && x.Senha == senha);

            return usuario == null ? null : GenerateJwtToken(usuario);
        }

        public async Task LogoutAsync(string token)
        {
            var jwtToken = new JwtSecurityTokenHandler().ReadJwtToken(token);

            if (jwtToken.ValidTo > DateTime.UtcNow)
            {
                var tokenInvalido = new AuthToken
                {
                    Token = token,
                    ExpiryDate = jwtToken.ValidTo
                };
            }
        }

        private string? GenerateJwtToken(Usuario usuario)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:SecretKey"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[] {
                new Claim(JwtRegisteredClaimNames.Sub, usuario.Email),
                new Claim("id", usuario.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddHours(1),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public async Task<bool> TokenIsValid(string token)
        {
            var invalidToken = await _tokenRepository.FirstOrDefaultAsync(t => t.Token == token);
            return invalidToken?.ExpiryDate > DateTime.UtcNow;
        }
    }
}
