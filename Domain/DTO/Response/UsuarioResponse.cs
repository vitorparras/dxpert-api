using Domain.Enum;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace Domain.DTO.Response
{
    public class UsuarioResponse : ResponseBase
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public TipoUsuario Permissao { get; set; }

    }
}
