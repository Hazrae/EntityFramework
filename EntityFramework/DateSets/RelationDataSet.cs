using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework
{
    //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    //!!! Ce fichier contient trois classes !!!
    //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    // Vérifiez bien les namespaces et le nom des classes d'entités !!!

    public class FilmDataSet : IEntityTypeConfiguration<Film>
    {
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            builder.HasData(
                new Film
                {
                    IdFilm = 1,
                    Titre = "Star Wars : Un nouvel espoir",
                    AnneeDeSortie = 1977,
                    Genre = "Science-Fiction",
                    IdReal = 10
                },
                new Film
                {
                    IdFilm = 2,
                    Titre = "Star Wars : L'empire contre-attaque",
                    AnneeDeSortie = 1980,
                    Genre = "Science-Fiction",
                    IdReal = 10
                },
                new Film
                {
                    IdFilm = 3,
                    Titre = "Star Wars : Le retour du Jedi",
                    AnneeDeSortie = 1983,
                    Genre = "Science-Fiction",
                    IdReal = 10
                },
                new Film
                {
                    IdFilm = 4,
                    Titre = "Hooligans",
                    AnneeDeSortie = 2005,
                    Genre = "Société",
                    IdReal = 8
                },
                new Film
                {
                    IdFilm = 5,
                    Titre = "LOTR - La communauté de l'anneau",
                    AnneeDeSortie = 2001,
                    Genre = "Heroic-Fantasy",
                    IdReal = 9
                },
                new Film
                {
                    IdFilm = 6,
                    Titre = "LOTR - Les deux tours",
                    AnneeDeSortie = 2002,
                    Genre = "Heroic-Fantasy",
                    IdReal = 9
                },
                new Film
                {
                    IdFilm = 7,
                    Titre = "LOTR - Le retour du roi",
                    AnneeDeSortie = 2003,
                    Genre = "Heroic-Fantasy",
                    IdReal = 9
                });
        }
    }

    public class PersonneDataSet : IEntityTypeConfiguration<Personne>
    {
        public void Configure(EntityTypeBuilder<Personne> builder)
        {
            builder.HasData
                (
                    new Personne 
                    { 
                        IdPers = 1,
                        Prenom = "Elijah",
                        Nom = "Wood"
                    },
                    new Personne
                    {
                        IdPers = 2,
                        Prenom = "Charlie",
                        Nom = "Hunnam"
                    },
                    new Personne
                    {
                        IdPers = 3,
                        Prenom = "Harisson",
                        Nom = "Ford"
                    },
                    new Personne
                    {
                        IdPers = 4,
                        Prenom = "Mark",
                        Nom = "Hammil"
                    },
                    new Personne
                    {
                        IdPers = 5,
                        Prenom = "Carrie",
                        Nom = "Fisher"
                    },
                    new Personne
                    {
                        IdPers = 6,
                        Prenom = "Vigo",
                        Nom = "Mortensen"
                    },
                    new Personne
                    {
                        IdPers = 7,
                        Prenom = "Orlando",
                        Nom = "Bloom"
                    },
                    new Personne
                    {
                        IdPers = 8,
                        Prenom = "Lexi",
                        Nom = "Alexander"
                    },
                    new Personne
                    {
                        IdPers = 9,
                        Prenom = "Peter",
                        Nom = "Jackson"
                    },
                    new Personne
                    {
                        IdPers = 10,
                        Prenom = "Georges",
                        Nom = "Lucas"
                    }
                );
        }
    }

    public class RelationDataSet : IEntityTypeConfiguration<Acteur>
    {
        public void Configure(EntityTypeBuilder<Acteur> builder)
        {
            builder.HasData
                (
                    new Acteur { IdActeur = 1, IdFilm = 1, IdPers = 3 },
                    new Acteur { IdActeur = 2, IdFilm = 1, IdPers = 4 },
                    new Acteur { IdActeur = 3, IdFilm = 1, IdPers = 5 },
                    new Acteur { IdActeur = 4, IdFilm = 2, IdPers = 3 },
                    new Acteur { IdActeur = 5, IdFilm = 2, IdPers = 4 },
                    new Acteur { IdActeur = 6, IdFilm = 2, IdPers = 5 },
                    new Acteur { IdActeur = 7, IdFilm = 3, IdPers = 3 },
                    new Acteur { IdActeur = 8, IdFilm = 3, IdPers = 4 },
                    new Acteur { IdActeur = 9, IdFilm = 3, IdPers = 5 },
                    new Acteur { IdActeur = 10, IdFilm = 4, IdPers = 1 },
                    new Acteur { IdActeur = 11, IdFilm = 4, IdPers = 2 },
                    new Acteur { IdActeur = 12, IdFilm = 5, IdPers = 1 },
                    new Acteur { IdActeur = 13, IdFilm = 5, IdPers = 6 },
                    new Acteur { IdActeur = 14, IdFilm = 5, IdPers = 7 },
                    new Acteur { IdActeur = 15, IdFilm = 6, IdPers = 1 },
                    new Acteur { IdActeur = 16, IdFilm = 6, IdPers = 6 },
                    new Acteur { IdActeur = 17, IdFilm = 6, IdPers = 7 },
                    new Acteur { IdActeur = 18, IdFilm = 7, IdPers = 1 },
                    new Acteur { IdActeur = 19, IdFilm = 7, IdPers = 6 },
                    new Acteur { IdActeur = 20, IdFilm = 7, IdPers = 7 }
                );
        }
    }
}
