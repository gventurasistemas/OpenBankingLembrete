using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RND.OpenBanking.Lembrete.Models
{
   [Table("Usuarios")]
    public class UsuarioModel
    {         
        [Key]
        public int UsuarioId { get; set; }
        public string NomeUsuario { get; set; }
      //  public virtual ICollection<LembreteModel> Lembretes { get; set; }
    }
}
