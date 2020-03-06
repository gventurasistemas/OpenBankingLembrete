using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RND.OpenBanking.Lembrete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RND.OpenBanking.Lembrete.Config
{
    public class LembreteConfig : IEntityTypeConfiguration<LembreteModel>
    {
        public void Configure(EntityTypeBuilder<LembreteModel> builder)
        {
            builder.ToTable("Lembretes");

            builder.HasKey(d => d.LembreteId);

            builder
                .Property(d => d.DescricaoLembrete)
                .IsRequired();
            builder
                .Property(c => c.CadastradoPor)
                .IsRequired();
        }
    }
}
