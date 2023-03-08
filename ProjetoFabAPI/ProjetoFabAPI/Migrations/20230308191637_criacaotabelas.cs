using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoFabAPI.Migrations
{
    /// <inheritdoc />
    public partial class criacaotabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipe",
                columns: table => new
                {
                    NomeEquipe = table.Column<string>(type: "varchar(50)", nullable: false),
                    Setor = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipe", x => x.NomeEquipe);
                });

            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    Nome = table.Column<string>(type: "varchar(50)", nullable: false),
                    Cargo = table.Column<string>(type: "varchar(50)", nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", nullable: false),
                    NomeEquipe = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.Nome);
                    table.ForeignKey(
                        name: "FK_Funcionario_Equipe_NomeEquipe",
                        column: x => x.NomeEquipe,
                        principalTable: "Equipe",
                        principalColumn: "NomeEquipe",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_NomeEquipe",
                table: "Funcionario",
                column: "NomeEquipe");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Funcionario");

            migrationBuilder.DropTable(
                name: "Equipe");
        }
    }
}
