using System;

namespace RND.OpenBanking.Lembrete.Models
{
    public class HorarioVistoModel
    {
        public int Id { get; set; }
        public DateTime HorarioQueFoiVisto { get; set; }
        public LembreteModel Lembretes { get; set; }
        public UsuarioModel Usuarios { get; set; }
    }
}
