using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Client : Personne
    {

        public string NumeroCarteFidelite { get; set; }

        public string Entreprise { get; set; }

        public virtual List<Facture> Factures { get; set; }

        //public bool Inactif { get; set; }

        //public bool Prospect { get; set; }

        //public bool CanalAcces { get; set; }

    }
}
