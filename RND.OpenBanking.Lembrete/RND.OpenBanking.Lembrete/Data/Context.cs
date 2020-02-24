using Microsoft.EntityFrameworkCore;
using RND.OpenBanking.Lembrete.Config;
using RND.OpenBanking.Lembrete.Models;

namespace RND.OpenBanking.Lembrete.Data
{
    public class Context : DbContext
    {
        public DbSet<LembreteModel> Lembretes { get; set; }
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LembreteConfig());
            base.OnModelCreating(modelBuilder);
        }
    }
}
