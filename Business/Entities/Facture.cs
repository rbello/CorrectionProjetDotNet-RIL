using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Facture
    {
        public int Id { get; set; }

        public string NumeroFacture { get; set; }

        public virtual Client Client { get; set; }

    }
}
