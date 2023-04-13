using Domain.Model;

namespace Service.Interfaces
{
    public interface IUsuarioService
    {
        Task<IEnumerable<Usuario>> GetAllAsync();
        Task<Usuario> GetByIdAsync(int id);
        Task<Usuario> AddAsync(Usuario usuario);
        Task UpdateAsync(Usuario usuario);
        Task DeleteAsync(int id);
        Task LogoutAsync(string token);
        Task<bool> TokenIsValid(string token);
        Task<string> LoginAsync(string email, string senha);
    }
}
