using EntityFramework.Entity;
using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;


namespace EntityFramework
{
    public class DataContext : DbContext
    {
        public DbSet<Film> ListeFlims { get; set; }
        public DbSet<Personne> ListePersonne { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=FORMA-VDI1114\TFTIC;Initial Catalog=TestEntity;Persist Security Info=True;User ID=sa;Password=tftic@2012");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)

            //Attention à bien add tous les fichiers de config et surtout dans le bon ordre des FK!
        {
           //Config table Film
           modelBuilder.ApplyConfiguration<Film>(new FilmConfig());           
           //modelBuilder.ApplyConfiguration<Film>(new DataSet());

            //Config table Personne
           modelBuilder.ApplyConfiguration<Personne>(new PersonneConfig());

            //Config Many-to-One Realisation
            modelBuilder.Entity<Personne>().HasMany(f=>f.Films).WithOne(r=>r.Realisateur).HasForeignKey("IdReal").OnDelete(DeleteBehavior.Restrict);

            //Config Many-to-Many Acteurs
            modelBuilder.ApplyConfiguration<Acteur>(new Acteurconfig());

            //Population table relationnelle
            modelBuilder.ApplyConfiguration(new PersonneDataSet());
            modelBuilder.ApplyConfiguration(new FilmDataSet());
            modelBuilder.ApplyConfiguration(new RelationDataSet());

            //Erreur à l'update car pas de comportement de delete spécifié => la many to many parametrée en cascade ne passe pas car risque de chier dans la colle cycliquement (je delete un film => les acteurs => les films => les acteurs etc)


        }
    }
}
