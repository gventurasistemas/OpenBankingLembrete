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
          //  modelBuilder.ApplyConfiguration(new UsuarioConfig());

            //modelBuilder.Entity<UsuarioModel>().HasData(
            //   new UsuarioModel()
            //   { UsuarioId = 1, NomeUsuario = "MARCIO" },
            //   new UsuarioModel()
            //   { UsuarioId = 2, NomeUsuario = "PEDRO" },
            //   new UsuarioModel()
            //   { UsuarioId = 3, NomeUsuario = "JOÃO" },
            //   new UsuarioModel()
            //   { UsuarioId = 4, NomeUsuario = "LUCAS" }              
            //   );

            //modelBuilder.Entity<LembreteModel>().HasData(
            //  new LembreteModel()
            //  { LembreteId = 1,
            //      DescricaoLembrete = "ABRIR EMAIL",
            //      Status = false,
            //      Visto = false,
            //      Efetuado = false,
            //      CadastradoPor = "Adimin",
            //      DataCadastro = new System.DateTime(2020, 03, 06),
            //      AlteradoPor = "Admin",
            //      DataAlteracao = new System.DateTime(2020,03,06),
            //      Usuario = { UsuarioId = 1, NomeUsuario = "PEDRO" }

            //  });
            base.OnModelCreating(modelBuilder);
        }
    }
}
