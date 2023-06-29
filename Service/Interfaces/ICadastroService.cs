using Domain.DTO.Request;
using Domain.DTO.Response;
using Domain.Model;
using System.Collections.Generic;

namespace Service.Interfaces
{
    public interface ICadastroService
    {
        Task<Cadastro> AddOrUpdate(Cadastro cadastro);
        Task<IEnumerable<Cadastro>> List();
        Task<IEnumerable<AcompanhamentosResponse>> ListAcompanhamentos(int? idUser);
        Task<bool> AddDescendentes(DescendentesRequest desc);
    }
}
