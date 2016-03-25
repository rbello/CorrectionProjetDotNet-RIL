using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class ReservationRepas : Reservation
    {

        public TypeRepas TypeRepas { get; set; }

        public override void Verifier()
        {
            // Vérification de base
            base.Verifier();
            // Vérifications spécifiques à ce type
            if (TypeRepas == null)
            {
                throw new Exception("Le type de repas doit être précisé");
            }
        }

    }
}
