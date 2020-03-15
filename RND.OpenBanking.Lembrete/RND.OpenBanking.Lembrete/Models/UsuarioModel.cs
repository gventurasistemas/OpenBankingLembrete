using System.Collections.Generic;

namespace RND.OpenBanking.Lembrete.Models
{
    //[Table("Usuarios")]
    public class UsuarioModel
    {         
       // [Key]
        public int UsuarioId { get; set; }
        public string NomeUsuario { get; set; }
        public virtual ICollection<LembreteModel> Lembretes { get; set; }
    }
}
