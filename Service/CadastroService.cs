using Domain.DTO.Request;
using Domain.Model;
using Repository.Interface;
using Service.Interfaces;

namespace Service
{
    public class CadastroService : ICadastroService
    {
        private readonly IGenericRepository<Cadastro> _CadastroRepository;

        public CadastroService(IGenericRepository<Cadastro> cadastroRepository)
        {
            _CadastroRepository = cadastroRepository ?? throw new ArgumentNullException(nameof(cadastroRepository));
        }

        public async Task<Cadastro> AddOrUpdate(Cadastro cadastro)
        {
            if (cadastro == null) { throw new ArgumentNullException(); }

            if (cadastro.Id != 0)
            {
                var cadastroexistente = await _CadastroRepository.FirstOrDefaultAsync(x => x.Id == cadastro.Id) ?? throw new ArgumentNullException();

                var alterado = AtualizarPropriedades(cadastroexistente, cadastro);

                var registroSalvo = await _CadastroRepository.UpdateAsync(alterado);

                return registroSalvo;
            }
            else
            {
                var inserido = await _CadastroRepository.AddAsync(cadastro);
                return inserido;
            }
        }

        private Cadastro AtualizarPropriedades(Cadastro cadastroExistente, Cadastro cadastro)
        {
            var properties = typeof(Cadastro).GetProperties();
            foreach (var property in properties)
            {
                var currentValue = property.GetValue(cadastroExistente);
                var newValue = property.GetValue(cadastro);

                if (newValue != null && !newValue.Equals(currentValue) && !newValue.Equals(default))
                {
                    property.SetValue(cadastroExistente, newValue);
                }
            }
            return cadastroExistente;
        }

        public async Task<IEnumerable<Cadastro>> List() => await _CadastroRepository.GetAllAsync();

        public async Task<bool> AddDescendentes(DescendentesRequest desc) => true;
            
            
    }
}
