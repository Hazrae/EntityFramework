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
        {
           //Config table Film
           modelBuilder.ApplyConfiguration<Film>(new FilmConfig());           
           //modelBuilder.ApplyConfiguration<Film>(new DataSet());

            //Config table Personne
           modelBuilder.ApplyConfiguration<Personne>(new PersonneConfig());

            //Config Many-to-One Realisation
            modelBuilder.Entity<Personne>().HasMany(f=>f.Films).WithOne(r=>r.Realisateur).HasForeignKey("IdReal").OnDelete(DeleteBehavior.Cascade);

            //Config Many-to-Many Acteurs
            modelBuilder.ApplyConfiguration(new Acteurconfig());

            //Population table relationnelle
            modelBuilder.ApplyConfiguration(new PersonneDataSet());
            modelBuilder.ApplyConfiguration(new FilmDataSet());
            modelBuilder.ApplyConfiguration(new RelationDataSet());

        }
    }
}
