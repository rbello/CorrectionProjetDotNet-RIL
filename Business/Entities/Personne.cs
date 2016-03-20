using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public abstract class Personne
    {
        public int Id { get; set; }

        public Civilite Civilite { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public string Email { get; set; }

        public string TelPortable { get; set; }

        public string TelFixe { get; set; }

        public string AdressePays { get; set; }

        public string AdresseVille { get; set; }

        public string AdresseCp { get; set; }

        public string Adresse1 { get; set; }

        public string Adresse2 { get; set; }
    }
}
