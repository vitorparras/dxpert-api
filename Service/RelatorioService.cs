using Domain.Model;
using Repository.Interface;

namespace Service
{
    public class RelatorioService
    {
        private readonly IGenericRepository<Relatorio> _RelatorioRepository;

        public RelatorioService(IGenericRepository<Relatorio> relatorioRepository)
        {
            _RelatorioRepository = relatorioRepository;
        }

        private void GerarMinhasPercas(Cadastro cadastro, double BeneficioInvalidez, double Aposentadoria, double PensaoPorMorte)
        {
            var minhasPercasNaAposentadoria = cadastro.Ocupacao == "Aposentado(a)"
                  ? 0
                  : cadastro.RendaBruta - Aposentadoria;

            var minhasPercasNaInvalidez = cadastro.Ocupacao == "Aposentado(a)"
                ? 0
                : cadastro.RendaBruta - BeneficioInvalidez;

            var minhasPercasNaPensaoPorMorte = cadastro.RendaBruta - PensaoPorMorte;

        }








    }
}
