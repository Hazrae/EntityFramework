using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Entity
{
    public class PersonneConfig : IEntityTypeConfiguration<Personne>
    {
        public void Configure(EntityTypeBuilder<Personne> builder)
        {
            // Nom de la table
            builder.ToTable("Personne");
            builder.HasKey("IdPers");

            // Champs
            builder.Property("IdPers").ValueGeneratedOnAdd();
            builder.Property("Nom").IsRequired();
            builder.Property("Prenom").IsRequired();
           


            //Format

            builder.Property("Nom").HasColumnType("VARCHAR(100)");
            builder.Property("Prenom").HasColumnType("VARCHAR(100)");
        


            //Contraintes
            
            

            //FK
        }
    }
}
