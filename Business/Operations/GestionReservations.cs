﻿using System;
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
            facture.NumeroFacture = Guid.NewGuid().ToString().ToUpper();
            businessLayer.Data.Factures.Add(facture);
            businessLayer.Data.SaveChanges();
            return facture;
        }

        public IQueryable<Facture> GetFacturesByClient(Client client)
        {
            return (from f in businessLayer.Data.Factures where f.Client == client select f);
        }

        public Facture GetFactureById(int id)
        {
            return (from f in businessLayer.Data.Factures where f.Id == id select f).FirstOrDefault();
        }

        public IQueryable<Reservation> GetReservationsByFacture(Facture facture)
        {
            return (from r in businessLayer.Data.Reservations where r.Facture == facture select r);
        }

        public IQueryable<Reservation> GetReservationsByFacture(int id)
        {
            return (from r in businessLayer.Data.Reservations where r.Facture.Id == id select r);
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


        public ReservationChambre GetReservation(Chambre room, DateTime dateTime)
        {
            return (from r in businessLayer.Data.Reservations.OfType<ReservationChambre>()
                    where r.Chambre.Id == room.Id && dateTime >= r.DateDebut && dateTime <= r.DateFin
                    select r).FirstOrDefault();
        }

        public List<ReservationChambre> GetReservations(DateTime dateTime)
        {
            return (from r in businessLayer.Data.Reservations.OfType<ReservationChambre>()
                    where dateTime >= r.DateDebut && dateTime <= r.DateFin
                    select r).ToList();
        }

        public Dictionary<Chambre, List<ReservationChambre>> GetReservations(DateTime begin, DateTime end)
        {
            return (from r in businessLayer.Data.Reservations.OfType<ReservationChambre>()
                    where begin >= r.DateDebut && end <= r.DateFin
                    select r)
                    .GroupBy(r => r.Chambre)
                    .ToDictionary(g => g.Key, g => g.ToList());
        }

    }
}
