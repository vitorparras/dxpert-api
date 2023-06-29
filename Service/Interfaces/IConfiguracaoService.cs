using Domain.Model;

namespace Service.Interfaces
{
    public interface IConfiguracaoService
    {
        Task<IEnumerable<Configuracoes>> GetAll();
        Task Update(int id, string value);
    }
}
