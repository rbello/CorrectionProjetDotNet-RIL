namespace Business.Migrations
{
    using Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Business.Entities.Entities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Business.Entities.Entities context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            var b = new BusinessLayer(context);
            
            b.GestionUtilisateurs.AjouterUtilisateur("admin", "admin", Permission.ALL);

            var opt1 = b.GestionHotel.AjouterOption("Vue sur le Cesi");
            var opt2 = b.GestionHotel.AjouterOption("Baignoire");
            var opt3 = b.GestionHotel.AjouterOption("Lit bébé");

            var room1 = b.GestionHotel.AjouterChambre(new Chambre()
            {
                Numero = "001",
                NbrLitsDouble = 1,
                NbrLitsSimple = 2,
                Disponible = true,
                Options = new List<OptionChambre>()
                {
                    opt1, opt3
                }
            });

            var room2 = b.GestionHotel.AjouterChambre(new Chambre()
            {
                Numero = "002",
                NbrLitsDouble = 2,
                NbrLitsSimple = 0,
                Disponible = true,
                Options = new List<OptionChambre>()
                {
                    opt2
                }
            });

            var client1 = b.GestionClients.AjouterClient(
                Civilite.Monsieur, "Jean", "Dujardin",
                "jean.dujardin@yahoo.com", "+33650984781", "0562189578",
                "France", "Toulouse", "31000", "6 rue des templiers", "appartement 7b");

            var client2 = b.GestionClients.AjouterClient(
                Civilite.Madame, "Anne", "Marbleu",
                "amarbleu@apple.fr", "+3361859715", "",
                "France", "Paris", "75200", "215 avenue Maslot", "Cedex 18", "Apple");

            var facture = b.GestionReservations.OuvrirFacture(new Facture()
            {
                Client = client1,
                NumeroFacture = Guid.NewGuid().ToString()
            });

            var resa = b.GestionReservations.AjouterReservation(facture, new ReservationChambre()
            {
                Chambre = room1,
                NbrPersonnes = 3,
                DateDebut = new DateTime(2016, 03, 25),
                DateFin   = new DateTime(2016, 03, 29)
            });
        }
    }
}
