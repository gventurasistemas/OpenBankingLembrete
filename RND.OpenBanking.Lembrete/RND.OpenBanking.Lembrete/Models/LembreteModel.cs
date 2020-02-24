using System;

namespace RND.OpenBanking.Lembrete.Models
{
    public class LembreteModel
    {
        public LembreteModel(int id,
            string nomeUsuario,
            string descricaoLembrete,
            DateTime horarioLembrete,
            bool status,
            bool visto,
            DateTime horarioQueFoiVisto,
            bool efetuado,
            string cadastradoPor,
            DateTime dataCadastro,
            string alteradoPor,
            DateTime dataAlteracao)
        {
            Id = id;
            NomeUsuario = nomeUsuario;
            DescricaoLembrete = descricaoLembrete;
            HorarioLembrete = horarioLembrete;
            Status = status;
            Visto = visto;
            HorarioQueFoiVisto = horarioQueFoiVisto;
            Efetuado = efetuado;
            CadastradoPor = cadastradoPor;
            DataCadastro = dataCadastro;
            AlteradoPor = alteradoPor;
            DataAlteracao = dataAlteracao;
        }
        public int Id { get; private set; }
        public string NomeUsuario { get; private set; }
        public string DescricaoLembrete { get; private set; }
        public DateTime HorarioLembrete { get; private set; }
        public bool Status { get; set; }
        public bool Visto { get; private set; }
        public DateTime HorarioQueFoiVisto { get; private set; }
        public bool Efetuado { get; private set; }
        public string CadastradoPor { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public string AlteradoPor { get; private set; }
        public DateTime DataAlteracao { get; private set; }
    }
}
