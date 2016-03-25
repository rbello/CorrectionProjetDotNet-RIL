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

        public IQueryable<Chambre> GetChambresDisponibles(bool dispo)
        {
            return (from c in businessLayer.Data.Chambres
                    where c.Disponible == dispo
                    select c);
        }

        public IQueryable<Chambre> GetChambresDisponibles(bool dispo, params OptionChambre[] options)
        {
            return (from c in businessLayer.Data.Chambres
                    where c.Disponible == dispo // les chambres disponibles
                    && !options.Except(c.Options).Any() // qui ont les options demandées
                    select c);
        }

        public IQueryable<OptionChambre> GetOptions()
        {
            return businessLayer.Data.OptionsChambre;
        }

    }
}
