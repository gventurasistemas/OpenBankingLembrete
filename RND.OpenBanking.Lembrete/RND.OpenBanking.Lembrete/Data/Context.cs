using Microsoft.EntityFrameworkCore;
using RND.OpenBanking.Lembrete.Config;
using RND.OpenBanking.Lembrete.Models;

namespace RND.OpenBanking.Lembrete.Data
{
    public class Context : DbContext
    {
        public DbSet<LembreteModel> Lembretes { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LembreteConfig());
            modelBuilder.ApplyConfiguration(new UsuarioConfig());

            modelBuilder.Entity<UsuarioModel>().HasData(
               new UsuarioModel()
               { UsuarioId = 1, NomeUsuario = "MARCIO" },
               new UsuarioModel()
               { UsuarioId = 2, NomeUsuario = "PEDRO" },
               new UsuarioModel()
               { UsuarioId = 3, NomeUsuario = "JOÃO" },
               new UsuarioModel()
               { UsuarioId = 4, NomeUsuario = "LUCAS" }
               );

            modelBuilder.Entity<LembreteModel>().HasData(
               new LembreteModel()
               { 
                   LembreteId = 1, 
                   DescricaoLembrete = "ATUALIZAR TFS",
                   DataEhHorarioLembrete = new System.DateTime(2020, 3, 12, 13, 31, 32, 11),
                   RepetirEm = new System.DateTime(2020, 1, 12, 00, 30, 00),
                   Status = false,
                   Visto = false,
                   Concluido = false,
                   CadastradoPor = "Admin",
                   DataCadastro = new System.DateTime(2020, 03, 10),
                   AlteradoPor = "Admin",
                   DataAlteracao = new System.DateTime(2020, 03, 10),
                   UsuarioId = 1 
               });
           
            base.OnModelCreating(modelBuilder);
        }
    }
}
