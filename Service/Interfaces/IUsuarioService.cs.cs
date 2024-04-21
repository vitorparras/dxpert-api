using Domain.DTO.Genericos;
using Domain.DTO.Request;
using Domain.DTO.Response;
using Domain.Model;

namespace Service.Interfaces
{
    public interface IUsuarioService
    {
        Task<Usuario> GetUserByEmail(string email);








        Task<ApiResponse<IEnumerable<UsuarioResponse>>> GetAllAsync();
        Task<ApiResponse<UsuarioResponse>> GetByIdAsync(int id);
        Task<ApiResponse<UsuarioResponse>> AddAsync(UsuarioRequest usuario);
        Task<ApiResponse<UsuarioResponse>> UpdateAsync(UsuarioRequest usuario);
        Task DeleteAsync(int id);
    }
}
