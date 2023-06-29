using Domain.DTO.Request;
using Domain.DTO.Response;
using Domain.Model;
using Repository.Interface;
using Service.Interfaces;

namespace Service
{
    public class CadastroService : ICadastroService
    {
        private readonly IGenericRepository<Cadastro> _CadastroRepository;
        private readonly IGenericRepository<Usuario> _UsuarioRepository;

        public CadastroService(IGenericRepository<Cadastro> cadastroRepository, IGenericRepository<Usuario> usuarioRepository)
        {
            _CadastroRepository = cadastroRepository ?? throw new ArgumentNullException(nameof(cadastroRepository));
            _UsuarioRepository = usuarioRepository ?? throw new ArgumentNullException(nameof(usuarioRepository));
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

        public async Task<IEnumerable<AcompanhamentosResponse>> ListAcompanhamentos(int? idUser)
        {
            var response = new List<AcompanhamentosResponse>();
            IEnumerable<Cadastro>? cads ;
            if (idUser != null)
            {
                cads = await _CadastroRepository.FindAsync(x=>x.IdUsuarioResponsavel == idUser);
            }
            else
            {
                 cads = await _CadastroRepository.GetAllAsync();
            }

            response.AddRange(cads.Select(x => new AcompanhamentosResponse()
            {
                CadastroEmail = x.Email,
                CadastroEtapa = x.Etapa,
                CadastroId = x.Id.ToString(),
                CadastroTelefone = x.Celular,
                UserResponsavel = GetNomeUsuarioResponsavel(x.IdUsuarioResponsavel).Result,
            }));

            return response;
        }

        public async Task<string> GetNomeUsuarioResponsavel(int idUser)
        {
            var user = await _UsuarioRepository.FirstOrDefaultAsync(x => x.Id == idUser);
            return user.Nome;
        }

    }
}
