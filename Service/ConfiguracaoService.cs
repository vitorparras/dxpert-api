using Domain.Model;
using Repository.Interface;
using Service.Interfaces;

namespace Service
{
    public class ConfiguracaoService : IConfiguracaoService
    {
        private readonly IGenericRepository<Configuracoes> _ConfigRepository;

        public ConfiguracaoService(IGenericRepository<Configuracoes> configRepository)
        {
            _ConfigRepository = configRepository ?? throw new ArgumentNullException(nameof(configRepository));
        }

        public async Task<IEnumerable<Configuracoes>> GetAll()
        {
            return await _ConfigRepository.GetAllAsync();
        }

        public async Task Update(int id, string value)
        {
            var configuracao = await _ConfigRepository.FirstOrDefaultAsync(x=>x.Id == id);

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
