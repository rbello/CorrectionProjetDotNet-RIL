using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public abstract class Reservation
    {

        public int Id { get; set; }

        public DateTime DateDebut { get; set; }

        public DateTime DateFin { get; set; }

        public int NbrPersonnes { get; set; }

        public virtual Facture Facture { get; set; }

        public virtual void Verifier()
        {
            if (Facture == null)
            {
                throw new Exception("La réservation doit être liée à une facture");
            }
            if (DateDebut >= DateFin)
            {
                throw new Exception("La date de fin est antérieure à la date de début");
            }
        }

        //public abstract double Tarif { get; }

        public Periode Periode
        {
            get
            {
                return new Periode()
                {
                    DateDebut = DateDebut,
                    DateFin = DateFin
                };
            }
        }

    }

    public class Periode
    {
        public DateTime DateDebut;
        public DateTime DateFin;
    }

}
