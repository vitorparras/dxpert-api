using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO.Request
{
    public class DescendentesRequest
    {
        public int IdCad { get; set; }
        public IEnumerable<FilhosObj> Filhos { get; set; }

    }

    public class FilhosObj
    {
        public DateTime? DtNasc { get; set; }
        public string Nome { get; set; }
    }
}
