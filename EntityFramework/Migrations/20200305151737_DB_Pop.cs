using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFramework.Migrations
{
    public partial class DB_Pop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Film_Personne_RealisateurIdPers",
                table: "Film");

            migrationBuilder.DropIndex(
                name: "IX_Film_RealisateurIdPers",
                table: "Film");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Acteur",
                table: "Acteur");

            migrationBuilder.DropColumn(
                name: "ActeurPrincipal",
                table: "Film");

            migrationBuilder.DropColumn(
                name: "RealisateurIdPers",
                table: "Film");

            migrationBuilder.AddColumn<int>(
                name: "IdReal",
                table: "Film",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdActeur",
                table: "Acteur",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Acteur",
                table: "Acteur",
                column: "IdActeur");

            migrationBuilder.InsertData(
                table: "Personne",
                columns: new[] { "IdPers", "Nom", "Prenom" },
                values: new object[,]
                {
                    { 1, "Wood", "Elijah" },
                    { 2, "Hunnam", "Charlie" },
                    { 3, "Ford", "Harisson" },
                    { 4, "Hammil", "Mark" },
                    { 5, "Fisher", "Carrie" },
                    { 6, "Mortensen", "Vigo" },
                    { 7, "Bloom", "Orlando" },
                    { 8, "Alexander", "Lexi" },
                    { 9, "Jackson", "Peter" },
                    { 10, "Lucas", "Georges" }
                });

            migrationBuilder.InsertData(
                table: "Film",
                columns: new[] { "IdFilm", "AnneeDeSortie", "Genre", "IdReal", "Titre" },
                values: new object[,]
                {
                    { 4, 2005, "Société", 8, "Hooligans" },
                    { 5, 2001, "Heroic-Fantasy", 9, "LOTR - La communauté de l'anneau" },
                    { 6, 2002, "Heroic-Fantasy", 9, "LOTR - Les deux tours" },
                    { 7, 2003, "Heroic-Fantasy", 9, "LOTR - Le retour du roi" },
                    { 1, 1977, "Science-Fiction", 10, "Star Wars : Un nouvel espoir" },
                    { 2, 1980, "Science-Fiction", 10, "Star Wars : L'empire contre-attaque" },
                    { 3, 1983, "Science-Fiction", 10, "Star Wars : Le retour du Jedi" }
                });

            migrationBuilder.InsertData(
                table: "Acteur",
                columns: new[] { "IdActeur", "IdFilm", "IdPers" },
                values: new object[,]
                {
                    { 10, 4, 1 },
                    { 7, 3, 3 },
                    { 6, 2, 5 },
                    { 5, 2, 4 },
                    { 4, 2, 3 },
                    { 3, 1, 5 },
                    { 2, 1, 4 },
                    { 1, 1, 3 },
                    { 20, 7, 7 },
                    { 19, 7, 6 },
                    { 18, 7, 1 },
                    { 17, 6, 7 },
                    { 16, 6, 6 },
                    { 15, 6, 1 },
                    { 14, 5, 7 },
                    { 13, 5, 6 },
                    { 12, 5, 1 },
                    { 11, 4, 2 },
                    { 8, 3, 4 },
                    { 9, 3, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Film_IdReal",
                table: "Film",
                column: "IdReal");

            migrationBuilder.CreateIndex(
                name: "IX_Acteur_IdPers",
                table: "Acteur",
                column: "IdPers");

            migrationBuilder.AddForeignKey(
                name: "FK_Film_Personne_IdReal",
                table: "Film",
                column: "IdReal",
                principalTable: "Personne",
                principalColumn: "IdPers",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Film_Personne_IdReal",
                table: "Film");

            migrationBuilder.DropIndex(
                name: "IX_Film_IdReal",
                table: "Film");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Acteur",
                table: "Acteur");

            migrationBuilder.DropIndex(
                name: "IX_Acteur_IdPers",
                table: "Acteur");

            migrationBuilder.DeleteData(
                table: "Acteur",
                keyColumn: "IdActeur",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Acteur",
                keyColumn: "IdActeur",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Acteur",
                keyColumn: "IdActeur",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Acteur",
                keyColumn: "IdActeur",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Acteur",
                keyColumn: "IdActeur",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Acteur",
                keyColumn: "IdActeur",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Acteur",
                keyColumn: "IdActeur",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Acteur",
                keyColumn: "IdActeur",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Acteur",
                keyColumn: "IdActeur",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Acteur",
                keyColumn: "IdActeur",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Acteur",
                keyColumn: "IdActeur",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Acteur",
                keyColumn: "IdActeur",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Acteur",
                keyColumn: "IdActeur",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Acteur",
                keyColumn: "IdActeur",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Acteur",
                keyColumn: "IdActeur",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Acteur",
                keyColumn: "IdActeur",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Acteur",
                keyColumn: "IdActeur",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Acteur",
                keyColumn: "IdActeur",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Acteur",
                keyColumn: "IdActeur",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Acteur",
                keyColumn: "IdActeur",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "IdFilm",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "IdFilm",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "IdFilm",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "IdFilm",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "IdFilm",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "IdFilm",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "IdFilm",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Personne",
                keyColumn: "IdPers",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Personne",
                keyColumn: "IdPers",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Personne",
                keyColumn: "IdPers",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Personne",
                keyColumn: "IdPers",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Personne",
                keyColumn: "IdPers",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Personne",
                keyColumn: "IdPers",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Personne",
                keyColumn: "IdPers",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Personne",
                keyColumn: "IdPers",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Personne",
                keyColumn: "IdPers",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Personne",
                keyColumn: "IdPers",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "IdReal",
                table: "Film");

            migrationBuilder.DropColumn(
                name: "IdActeur",
                table: "Acteur");

            migrationBuilder.AddColumn<string>(
                name: "ActeurPrincipal",
                table: "Film",
                type: "VARCHAR(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "RealisateurIdPers",
                table: "Film",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Acteur",
                table: "Acteur",
                columns: new[] { "IdPers", "IdFilm" });

            migrationBuilder.CreateIndex(
                name: "IX_Film_RealisateurIdPers",
                table: "Film",
                column: "RealisateurIdPers");

            migrationBuilder.AddForeignKey(
                name: "FK_Film_Personne_RealisateurIdPers",
                table: "Film",
                column: "RealisateurIdPers",
                principalTable: "Personne",
                principalColumn: "IdPers",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
