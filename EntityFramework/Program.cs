
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            /*try
            {
                
                using (DataContext dc = new DataContext())
                {
                    dc.ListeFlims.Add(new Film
                    {
                        Titre = "Pacific RIm",
                        ActeurPrincipal = "Charlie Hunnam",
                        Realisateur = "Guillermo Del Toro",
                        AnneeDeSortie = 2013,
                        Genre = "Action"
                    });
                    dc.SaveChanges();
                    
                using (DataContext dc = new DataContext())
                {
                    var liste = dc.ListeFlims.Where(x => x.AnneeDeSortie < 2001);
                    foreach (var f in liste)
                    {
                        Console.WriteLine("Titre : " +f.Titre);
                        Console.WriteLine("Acteur : " +f.ActeurPrincipal);
                        Console.WriteLine("Realisateur : " +f.Realisateur);
                        Console.WriteLine("Annee de sortie : " +f.AnneeDeSortie);
                        Console.WriteLine("Genre : " +f.Genre);
                        Console.WriteLine();

                    }
                }

                /*using (DataContext dc = new DataContext())
                {
                    var liste = dc.ListeFlims.Where(x => x.Titre.Contains("Star Wars"));

                    foreach (var f in liste)
                    {
                        f.ActeurPrincipal = "Harrison Ford";
                    }
                    dc.SaveChanges();
                }

                using (DataContext dc = new DataContext())
                {
                    var liste = dc.ListeFlims.Where(x => x.ActeurPrincipal == "Charlie Hunnam");
                    foreach (var f in liste)
                    {
                        dc.Remove(f);
                    }
                    dc.SaveChanges();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.GetType());
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.GetType());
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("I HAVE THE HIGH GROUND ANAKIN!!!!");
            }
            */
            using (DataContext dc = new DataContext())
            {
                var FullFilms = dc.ListeFlims.Include(x => x.Realisateur)
                                             .Include(x=>x.Acteurs).ThenInclude(x=>x.P)
                                             .ToList();
                foreach (var f in FullFilms)
                {
                    Console.WriteLine($"{f.Titre} a été réalisé par {f.Realisateur.Nom} {f.Realisateur.Prenom}  et les acteurs sont : ");
                    foreach (var acteur in f.Acteurs)
                    {
                        Console.Write(acteur.P.Nom);
                    }
                }
             }
        }
    }
}
