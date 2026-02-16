using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class InicializarTabelaCaixas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CaixaId",
                table: "Categorias",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "Caixas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caixas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Caixas",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1L, "Criar pensamento" },
                    { 2L, "Organizar pensamentos" },
                    { 3L, "Talvez ou depois" },
                    { 4L, "Próximas ações" },
                    { 5L, "Projetos" },
                    { 6L, "Calendario" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categorias_CaixaId",
                table: "Categorias",
                column: "CaixaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categorias_Caixas_CaixaId",
                table: "Categorias",
                column: "CaixaId",
                principalTable: "Caixas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categorias_Caixas_CaixaId",
                table: "Categorias");

            migrationBuilder.DropTable(
                name: "Caixas");

            migrationBuilder.DropIndex(
                name: "IX_Categorias_CaixaId",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "CaixaId",
                table: "Categorias");
        }
    }
}
