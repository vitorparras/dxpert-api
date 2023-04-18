using Domain.DTO.Request;
using Domain.DTO.Response;
using Domain.Model;

namespace Service.Interfaces
{
    public interface IUsuarioService
    {
        Task<IEnumerable<UsuarioResponse>> GetAllAsync();
        Task<UsuarioResponse> GetByIdAsync(int id);
        Task<UsuarioResponse> AddAsync(UsuarioRequest usuario);
        Task<UsuarioResponse> UpdateAsync(UsuarioRequest usuario);
        Task DeleteAsync(int id);
        Task LogoutAsync(string token);
        Task<bool> TokenIsValid(string token);
        Task<LoginResponse> LoginAsync(string email, string senha);
    }
}
