using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RND.OpenBanking.Lembrete.Models;

namespace RND.OpenBanking.Lembrete.Config
{
    public class UsuarioConfig : IEntityTypeConfiguration<UsuarioModel>
    {
        public void Configure(EntityTypeBuilder<UsuarioModel> builder)
        {
            //builder.ToTable("Usuarios");

            //builder.HasKey(a => a.UsuarioId);

            //builder
            //   .Property(d => d.NomeUsuario)
            //   .IsRequired();
            //builder
            //    .Property(c => c.Lembretes)
            //    .IsRequired();
        }
    }
}
