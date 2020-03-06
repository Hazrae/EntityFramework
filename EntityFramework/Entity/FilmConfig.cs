using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework
{
    class FilmConfig : IEntityTypeConfiguration<Film>
    {
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            // Nom de la table
            builder.ToTable("Film");
            builder.HasKey("IdFilm");

            // Champs
            builder.Property("IdFilm").ValueGeneratedOnAdd();
            builder.Property("Titre").IsRequired();
            builder.Property("AnneeDeSortie").IsRequired();
            builder.Property("Genre").IsRequired();
     

            //Format


            builder.Property("Titre").HasColumnType("VARCHAR(100)");
            builder.Property("AnneeDeSortie").HasColumnType("INTEGER");
            builder.Property("Genre").HasColumnType("VARCHAR(100)");
        

            //Contraintes

            builder.HasIndex(x => x.Titre).IsUnique();
            builder.HasCheckConstraint("CK_FILM", "AnneeDeSortie > 1975");

            //FK
           

          






        }
    }
}
