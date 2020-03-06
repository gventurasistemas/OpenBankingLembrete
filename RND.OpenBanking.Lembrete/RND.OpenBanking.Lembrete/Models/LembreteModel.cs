using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RND.OpenBanking.Lembrete.Models
{  
    public class LembreteModel
    {       
        public int LembreteId { get;  set; }
        public string DescricaoLembrete { get;  set; }
        public bool Status { get; set; }
        public bool Visto { get;  set; }
        public bool Efetuado { get;  set; }
        public string CadastradoPor { get;  set; }
        public DateTime DataCadastro { get;  set; }
        public string AlteradoPor { get;  set; }
        public DateTime DataAlteracao { get;  set; }       
        public virtual UsuarioModel Usuario { get; set; }
    }
}
