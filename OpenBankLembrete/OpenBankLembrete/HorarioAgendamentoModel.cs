using System;

namespace OpenBankLembrete
{
    public class HorarioAgendamentoModel
    {
        public int Id { get; set; }
        public DateTime HorarioLembrete { get; set; }
        public LembreteModel Lembretes { get; set; }
    }
}
