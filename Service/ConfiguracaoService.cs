using Domain.Model;
using Repository.Interface;
using Service.Interfaces;

namespace Service
{
    internal class ConfiguracaoService : IConfiguracaoService
    {
        private readonly IGenericRepository<Configuracoes> _ConfigRepository;


        public async Task<IEnumerable<Configuracoes>> GetAll()
        {
            return await _ConfigRepository.GetAllAsync();
        }

        public async void Update(int id, string value)
        {
            var configuracao = await _ConfigRepository.GetByIdAsync(id);

            if (configuracao != null)
            {
                configuracao.Valor = value;
                await _ConfigRepository.UpdateAsync(configuracao);
            }
            else
            {
                throw new ArgumentException("Configuração não encontrada");
            }
        }
    }
}
