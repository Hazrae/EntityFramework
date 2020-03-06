using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Models
{
    public class Acteur
    {
        public int IdActeur { get; set; }
        public int IdFilm { get; set; }
        public Film F { get; set; }
        public int IdPers { get; set; }
        public Personne P { get; set; }

    }
}
