using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using System.Data.Entity;

namespace Business.Operations
{
    public class GestionReservations
    {
        private BusinessLayer businessLayer;

        public GestionReservations(BusinessLayer businessLayer)
        {
            this.businessLayer = businessLayer;
        }

        public Facture OuvrirFacture(Facture facture)
        {
            businessLayer.Data.Factures.Add(facture);
            businessLayer.Data.SaveChanges();
            return facture;
        }

        public Reservation AjouterReservation(Facture facture, Reservation resa)
        {
            // On associe la facture
            resa.Facture = facture;
            // Vérifications
            resa.Verifier();
            // On enregistre
            businessLayer.Data.Reservations.Add(resa);
            businessLayer.Data.SaveChanges();
            return resa;
        }
    }
}
