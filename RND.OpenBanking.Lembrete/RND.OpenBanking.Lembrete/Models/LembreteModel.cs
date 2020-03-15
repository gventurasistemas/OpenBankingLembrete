using System;

namespace RND.OpenBanking.Lembrete.Models
{
    public class LembreteModel
    {
        public int LembreteId { get; set; }
        public string DescricaoLembrete { get; set; }
        public DateTime DataEhHorarioLembrete { get; set; }
        public DateTime RepetirEm { get; set; }
        public bool Status { get; set; }//Ativado ou desativado
        public bool Visto { get; set; }
        public bool Concluido { get; set; }
        public string CadastradoPor { get; set; }
        public DateTime DataCadastro { get; set; }
        public string AlteradoPor { get; set; }
        public DateTime DataAlteracao { get; set; }
        public int UsuarioId { get; set; }
        public virtual UsuarioModel Usuario { get; set; }

    }
}
