using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Models
{
    public class Personne
    {
        public int IdPers { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        

        //Many-to-one
        public List<Film> Films { get; set;}

        //Many-to-Many
        public List<Acteur> Actorat { get; set; }

    }
}
