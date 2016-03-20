using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Utilisateur : Personne
    {

        public string Login { get; set; }

        public string Password { get; set; }

        public Permission Permissions { get; set; }

        public string GetUserType()
        {
            if (Permissions.HasFlag(Permission.MANAGER)) return "Manager";
            if (Permissions.HasFlag(Permission.RESERVATION)) return "Réservation";
            if (Permissions.HasFlag(Permission.NETTOYAGE)) return "Nettoyage";
            if (Permissions.HasFlag(Permission.CUISINE)) return "Cuisine";
            return "Visiteur";
        }
    }
}
