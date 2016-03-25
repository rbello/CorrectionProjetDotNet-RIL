using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using System.Data.Entity;

namespace Business.Operations
{
    public class GestionHotel
    {
        private BusinessLayer businessLayer;

        public GestionHotel(BusinessLayer businessLayer)
        {
            this.businessLayer = businessLayer;
        }

        public Chambre AjouterChambre(Chambre chambre)
        {
            businessLayer.Data.Chambres.Add(chambre);
            businessLayer.Data.SaveChanges();
            return chambre;
        }

        public OptionChambre AjouterOption(string name)
        {
            var opt = new OptionChambre() { Nom = name };
            businessLayer.Data.OptionsChambre.Add(opt);
            businessLayer.Data.SaveChanges();
            return opt;
        }
    }
}
