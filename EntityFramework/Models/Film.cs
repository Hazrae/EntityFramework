using EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework
{
    public class Film
    {
        public int IdFilm { get; set; }
        public string Titre { get; set; }
        public int AnneeDeSortie { get; set; }
        public string Genre { get; set; }

        public int IdReal { get; set; }


        //One-to-Many
        public Personne Realisateur { get; set; }

        //Many-to-Many
        public List<Acteur> Acteurs {get; set;}


       

   

    }
}
