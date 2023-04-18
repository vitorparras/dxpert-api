using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Domain.DTO.Request;
using Domain.DTO.Response;
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

        public async Task<IEnumerable<UsuarioResponse>> GetAllAsync()
        {
            var result = await _usuarioRepository.GetAllAsync();
            return result.Select(x => new UsuarioResponse()
            {
                Email = x.Email,
                Id = x.Id,
                Nome = x.Nome,
                Permissao = x.Permissao,
                Telefone = x.Telefone
            }).ToList();
        }

        public async Task<UsuarioResponse> GetByIdAsync(int id)
        {
            var result = await _usuarioRepository.GetByIdAsync(id);
            return new UsuarioResponse()
            {
                Email = result.Email,
                Id = result.Id,
                Nome = result.Nome,
                Permissao = result.Permissao,
                Telefone = result.Telefone
            };
        }

        public async Task<UsuarioResponse> AddAsync(UsuarioRequest usuario)
        {
           var user = await _usuarioRepository.AddAsync( new Usuario()
            {
                Telefone= usuario.Telefone,
                Permissao= usuario.Permissao,
                Nome= usuario.Nome,
                Senha= usuario.Senha,
                Email= usuario.Email,
            });

            return new UsuarioResponse()
            {
                Email = user.Email,
                Id = user.Id,
                Nome = user.Nome,
                Permissao = user.Permissao,
                Telefone = user.Telefone
            };
        }

        public async Task<UsuarioResponse> UpdateAsync(UsuarioRequest usuario)
        {
            var userExistente = await _usuarioRepository.GetByIdAsync(usuario.Id);

            if (userExistente != null)
            {
                userExistente.Senha = usuario.Senha;
                userExistente.Permissao = usuario.Permissao;
                userExistente.Telefone = usuario.Telefone;
                userExistente.Email = usuario.Email;
                userExistente.Nome = usuario.Nome;

                userExistente = await _usuarioRepository.UpdateAsync(userExistente);
            }

            return new UsuarioResponse()
            {
                Email = userExistente.Email,
                Id = userExistente.Id,
                Nome = userExistente.Nome,
                Permissao = userExistente.Permissao,
                Telefone = userExistente.Telefone
            };
        }

        public async Task DeleteAsync(int id)
        {
            var user = await _usuarioRepository.GetByIdAsync(id);
            if (user != null)
            {
                await _usuarioRepository.RemoveAsync(user);
            }
        }

        public async Task<LoginResponse> LoginAsync(string email, string senha)
        {
            var usuario = await _usuarioRepository
                .FirstOrDefaultAsync(x => x.Ativo
                                && x.Email.Contains(email)
                                && x.Senha.Contains(senha));

            if (usuario != null)
            {
                var token = GenerateJwtToken(usuario);

                if (token != null)
                {
                    var validTo = new JwtSecurityTokenHandler().ReadJwtToken(token).ValidTo;

                    await _tokenRepository.AddAsync(new AuthToken
                    {
                        Token = token,
                        ExpiryDate = validTo
                    });
                    return new LoginResponse()
                    {
                        IdUser = usuario.Id,
                        Token = token,
                        Nome = usuario.Nome,
                        Mensagem = "Usuario Validado Com Sucesso",
                        Sucesso = true
                    };

                }
            }

            return new LoginResponse()
            {
                Mensagem = "Usuario Informado Invalido",
                Sucesso = false
            };
        }

        public async Task LogoutAsync(string token)
        {
            var jwtToken = new JwtSecurityTokenHandler().ReadJwtToken(token);

            var tokenBd = await _tokenRepository.FirstOrDefaultAsync(x => x.Token == token);

            if (tokenBd != null)
            {
                tokenBd.ExpiryDate = DateTime.UtcNow.AddMinutes(-1);
                await _tokenRepository.UpdateAsync(tokenBd);
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
