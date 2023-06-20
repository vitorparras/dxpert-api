using Domain.Model;
using System.Collections.Generic;

namespace Domain.DTO.Response
{
    public class CadastroResponse : ResponseBase
    {
        public Cadastro? Cadastro { get; set; }
    }
    
    public class CadastroListResponse : ResponseBase
    {
        public IEnumerable<Cadastro> Cadastros { get; set; }
    }
}
