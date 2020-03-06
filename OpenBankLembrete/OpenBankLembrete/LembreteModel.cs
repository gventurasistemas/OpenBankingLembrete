using System;

namespace OpenBankLembrete
{
    public class LembreteModel
    {
        //public LembreteModel(int lembreteId, string descricaoLembrete, bool status, bool visto, bool efetuado, string cadastradoPor, DateTime dataCadastro, string alteradoPor, DateTime dataAlteracao)
        //{
        //    LembreteId = lembreteId;
        //    DescricaoLembrete = descricaoLembrete;
        //    Status = status;
        //    Visto = visto;
        //    Efetuado = efetuado;
        //    CadastradoPor = cadastradoPor;
        //    DataCadastro = dataCadastro;
        //    AlteradoPor = alteradoPor;
        //    DataAlteracao = dataAlteracao;          
        //}

        public int LembreteId { get; set; }
        public string DescricaoLembrete { get; set; }
        public bool Status { get; set; }
        public bool Visto { get; set; }
        public bool Efetuado { get; set; }
        public string CadastradoPor { get; set; }
        public DateTime DataCadastro { get; set; }
        public string AlteradoPor { get; set; }
        public DateTime DataAlteracao { get; set; }
        public virtual UsuarioModel Usuario { get; set; }
    }
}
