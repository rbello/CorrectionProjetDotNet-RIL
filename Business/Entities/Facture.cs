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

        public virtual List<Reservation> Reservations { get; set; }

        public Periode GetPeriodeSejour()
        {
            return Reservations
                // On cherche les réservations de chambre
                .Where(r => r.GetType() == typeof(ReservationChambre))
                // On récupère uniquement les périodes
                .Select(r => r.Periode)
                // Et on récupère une unique période avec les min et max
                .Aggregate(new Periode(), (a, b) =>
                {
                    return new Periode()
                    {
                        DateDebut = a.DateDebut > b.DateDebut ? a.DateDebut : b.DateDebut,
                        DateFin = a.DateFin > b.DateFin ? b.DateFin : a.DateFin
                    };
                });
        }

    }

}
