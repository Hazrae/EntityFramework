using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFramework.Migrations
{
    public partial class _1ToMClean_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personne",
                columns: table => new
                {
                    IdPers = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Prenom = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personne", x => x.IdPers);
                });

            migrationBuilder.CreateTable(
                name: "Film",
                columns: table => new
                {
                    IdFilm = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titre = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    AnneeDeSortie = table.Column<int>(type: "INTEGER", nullable: false),
                    ActeurPrincipal = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Genre = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    RealisateurIdPers = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Film", x => x.IdFilm);
                    table.CheckConstraint("CK_FILM", "AnneeDeSortie > 1975");
                    table.ForeignKey(
                        name: "FK_Film_Personne_RealisateurIdPers",
                        column: x => x.RealisateurIdPers,
                        principalTable: "Personne",
                        principalColumn: "IdPers",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Film_RealisateurIdPers",
                table: "Film",
                column: "RealisateurIdPers");

            migrationBuilder.CreateIndex(
                name: "IX_Film_Titre",
                table: "Film",
                column: "Titre",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Film");

            migrationBuilder.DropTable(
                name: "Personne");
        }
    }
}
