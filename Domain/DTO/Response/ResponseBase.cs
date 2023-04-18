using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO.Response
{
    public class ResponseBase
    {
        public string? Mensagem { get; set; }
        public bool Sucesso { get; set; }
    }
}
