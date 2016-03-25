using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Chambre
    {
        public int Id { get; set; }

        public string Numero { get; set; }

        public int NbrLitsSimple { get; set; }

        public int NbrLitsDouble { get; set; }

        public bool Disponible { get; set; }

        public virtual List<OptionChambre> Options { get; set; }

        public int GetCapaciteMax()
        {
            return NbrLitsDouble * 2 + NbrLitsSimple;
        }
    }
}
