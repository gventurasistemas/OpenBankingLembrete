using System;

namespace RND.OpenBanking.Lembrete.Models
{
    public class HorarioAgendamentoModel
    {
        public int Id { get; set; }
        public DateTime DataEhHorarioLembrete { get; set; }
        public LembreteModel Lembretes { get; set; }
    }
}
