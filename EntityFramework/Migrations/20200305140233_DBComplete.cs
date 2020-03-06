using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFramework.Migrations
{
    public partial class DBComplete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Acteur",
                columns: table => new
                {
                    IdFilm = table.Column<int>(nullable: false),
                    IdPers = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acteur", x => new { x.IdPers, x.IdFilm });
                    table.ForeignKey(
                        name: "FK_Acteur_Film_IdFilm",
                        column: x => x.IdFilm,
                        principalTable: "Film",
                        principalColumn: "IdFilm",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Acteur_Personne_IdPers",
                        column: x => x.IdPers,
                        principalTable: "Personne",
                        principalColumn: "IdPers",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Acteur_IdFilm",
                table: "Acteur",
                column: "IdFilm");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Acteur");
        }
    }
}
