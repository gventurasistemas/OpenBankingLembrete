using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RND.OpenBanking.Lembrete.Models
{
    public class HorarioAgendamentoModel
    {
        public int Id { get; set; }
        public DateTime HorarioLembrete { get; set; }
        public LembreteModel Lembretes { get; set; }
    }
}
