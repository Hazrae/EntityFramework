using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Entity
{
    class Acteurconfig : IEntityTypeConfiguration<Acteur>
    {
        public void Configure(EntityTypeBuilder<Acteur> builder)
        {
            builder.ToTable("Acteur");
            builder.HasKey(a => a.IdActeur); //PK
            
            builder.Property("IdActeur").HasColumnType("INTEGER").ValueGeneratedOnAdd(); //AutoIncrement
                        
            builder.HasOne(af => af.F)
                    .WithMany(a => a.Acteurs)
                    .HasForeignKey(fk => fk.IdFilm);

            builder.HasOne(fa => fa.P)
                    .WithMany(f => f.Actorat)
                    .HasForeignKey(fk => fk.IdPers);
                    
        }
    }
}
