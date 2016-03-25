using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class ReservationChambre : Reservation
    {

        public virtual Chambre Chambre { get; set; }

        public override void Verifier()
        {
            // Vérification de base
            base.Verifier();
            // Vérifications spécifiques à ce type
            if (Chambre == null)
            {
                throw new Exception("Une réservation de chambre doit être liée à une chambre");
            }
            if (Chambre.GetCapaciteMax() < NbrPersonnes)
            {
                throw new Exception("Le nombre de personnes dépasse la capacité de la chambre");
            }
        }

    }
}
