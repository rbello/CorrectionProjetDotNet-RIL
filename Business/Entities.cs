namespace Business.Entities
{
    using System.Data.Entity;

    public class Entities : DbContext
    {
        // Votre contexte a été configuré pour utiliser une chaîne de connexion « Entities » du fichier 
        // de configuration de votre application (App.config ou Web.config). Par défaut, cette chaîne de connexion cible 
        // la base de données « Business.Entities » sur votre instance LocalDb. 
        // 
        // Pour cibler une autre base de données et/ou un autre fournisseur de base de données, modifiez 
        // la chaîne de connexion « Entities » dans le fichier de configuration de l'application.
        public Entities()
            : base("name=Entities")
        {
        }

        // Ajoutez un DbSet pour chaque type d'entité à inclure dans votre modèle. Pour plus d'informations 
        // sur la configuration et l'utilisation du modèle Code First, consultez http://go.microsoft.com/fwlink/?LinkId=390109.

        // La migration automatique des modèles est possible, consultez https://msdn.microsoft.com/en-us/data/jj591621
        // Pour activer la migration :
        //   Enable-Migrations -Force
        //   Add-Migration init
        //   Update-Database

        public virtual DbSet<Personne> Personnes { get; set; }
        public virtual DbSet<Utilisateur> Utilisateurs { get; set; }
        public virtual DbSet<Client> Clients { get; set; }

        public virtual DbSet<Facture> Factures { get; set; }

        public virtual DbSet<OptionChambre> OptionsChambre { get; set; }
        public virtual DbSet<Chambre> Chambres { get; set; }

        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<ReservationTennis> ReservationsTennis { get; set; }
        public virtual DbSet<ReservationRepas> ReservationsRepas { get; set; }
        public virtual DbSet<ReservationFitness> ReservationsFitness { get; set; }
        public virtual DbSet<ReservationChambre> ReservationsChambre { get; set; }

        
    }

}