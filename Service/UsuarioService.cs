using Domain.DTO.Request;
using Domain.DTO.Response;
using Domain.Model;
using Infrastructure.Repository.Interface;
using Microsoft.Extensions.Configuration;
using Service.Interfaces;

namespace Service
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IGenericRepository<Usuario> _usuarioRepository;
        private readonly IConfiguration _configuration;

        public UsuarioService(
            IGenericRepository<Usuario> usuarioRepository,
            IConfiguration configuration)
        {
            _usuarioRepository = usuarioRepository ?? throw new ArgumentNullException(nameof(usuarioRepository));
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        public async Task<Usuario> GetUserByEmail(string email)
        {
            var result = await _usuarioRepository.FirstOrDefaultAsync(x => x.Email.Contains(email));
            return result;
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
            if (result != null)
            {
                return new UsuarioResponse()
                {
                    Email = result.Email,
                    Id = result.Id,
                    Nome = result.Nome,
                    Permissao = result.Permissao,
                    Telefone = result.Telefone
                };
            }
            return null;
        }

        public async Task<UsuarioResponse> AddAsync(UsuarioRequest usuario)
        {
            var user = await _usuarioRepository.AddAsync(new Usuario()
            {
                Telefone = usuario.Telefone,
                Permissao = usuario.Permissao,
                Nome = usuario.Nome,
                Senha = usuario.Senha,
                Email = usuario.Email,
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
    }
}
