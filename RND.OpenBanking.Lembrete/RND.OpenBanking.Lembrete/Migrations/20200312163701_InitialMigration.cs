using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RND.OpenBanking.Lembrete.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeUsuario = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Lembretes",
                columns: table => new
                {
                    LembreteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DescricaoLembrete = table.Column<string>(nullable: false),
                    DataEhHorarioLembrete = table.Column<DateTime>(nullable: false),
                    RepetirEm = table.Column<DateTime>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    Visto = table.Column<bool>(nullable: false),
                    Concluido = table.Column<bool>(nullable: false),
                    CadastradoPor = table.Column<string>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    AlteradoPor = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lembretes", x => x.LembreteId);
                    table.ForeignKey(
                        name: "FK_Lembretes_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioId", "NomeUsuario" },
                values: new object[,]
                {
                    { 1, "MARCIO" },
                    { 2, "PEDRO" },
                    { 3, "JOÃO" },
                    { 4, "LUCAS" }
                });

            migrationBuilder.InsertData(
                table: "Lembretes",
                columns: new[] { "LembreteId", "AlteradoPor", "CadastradoPor", "Concluido", "DataAlteracao", "DataCadastro", "DataEhHorarioLembrete", "DescricaoLembrete", "RepetirEm", "Status", "UsuarioId", "Visto" },
                values: new object[] { 1, "Admin", "Admin", false, new DateTime(2020, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 12, 13, 31, 32, 11, DateTimeKind.Unspecified), "ATUALIZAR TFS", new DateTime(2020, 1, 12, 0, 30, 0, 0, DateTimeKind.Unspecified), false, 1, false });

            migrationBuilder.CreateIndex(
                name: "IX_Lembretes_UsuarioId",
                table: "Lembretes",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lembretes");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
