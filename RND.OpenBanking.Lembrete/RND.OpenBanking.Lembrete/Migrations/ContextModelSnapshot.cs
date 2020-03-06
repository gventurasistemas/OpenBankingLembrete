﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RND.OpenBanking.Lembrete.Data;

namespace RND.OpenBanking.Lembrete.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RND.OpenBanking.Lembrete.Models.LembreteModel", b =>
                {
                    b.Property<int>("LembreteId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AlteradoPor");

                    b.Property<string>("CadastradoPor")
                        .IsRequired();

                    b.Property<DateTime>("DataAlteracao");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("DescricaoLembrete")
                        .IsRequired();

                    b.Property<bool>("Efetuado");

                    b.Property<bool>("Status");

                    b.Property<int?>("UsuarioId");

                    b.Property<bool>("Visto");

                    b.HasKey("LembreteId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Lembretes");
                });

            modelBuilder.Entity("RND.OpenBanking.Lembrete.Models.UsuarioModel", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeUsuario");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("RND.OpenBanking.Lembrete.Models.LembreteModel", b =>
                {
                    b.HasOne("RND.OpenBanking.Lembrete.Models.UsuarioModel", "Usuario")
                        .WithMany("Lembretes")
                        .HasForeignKey("UsuarioId");
                });
#pragma warning restore 612, 618
        }
    }
}
