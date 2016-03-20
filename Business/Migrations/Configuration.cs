namespace Business.Migrations
{
    using Entities;
    using System;
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
            b.GestionClients.AjouterClient(
                Civilite.Monsieur, "Jean", "Dujardin",
                "jean.dujardin@yahoo.com", "+33650984781", "0562189578",
                "France", "Toulouse", "31000", "6 rue des templiers", "appartement 7b");
            b.GestionClients.AjouterClient(
                Civilite.Madame, "Anne", "Marbleu",
                "amarbleu@apple.fr", "+3361859715", "",
                "France", "Paris", "75200", "215 avenue Maslot", "Cedex 18", "Apple");

        }
    }
}
