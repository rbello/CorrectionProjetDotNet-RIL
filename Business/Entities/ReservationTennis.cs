using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class ReservationTennis : Reservation
    {
        public override void Verifier()
        {
            // Vérification de base
            base.Verifier();
            // Vérifications spécifiques à ce type
            if (DateFin - DateDebut < new TimeSpan(12, 0, 0))
            {
                throw new Exception("La période de réservation doit être d'au moins 4 heures");
            }
        }
    }
}
