using Domain.Model;

namespace Service.Interfaces
{
    public interface IConfiguracaoService
    {
        Task<IEnumerable<Configuracoes>> GetAll();
        void Update(int id, string value);
    }
}
