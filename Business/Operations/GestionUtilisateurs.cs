using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Business.Operations
{
    public class GestionUtilisateurs
    {
        private BusinessLayer businessLayer;

        public GestionUtilisateurs(BusinessLayer businessLayer)
        {
            this.businessLayer = businessLayer;
        }

        public void AjouterUtilisateur(string login, string password, Entities.Permission perm)
        {
            var user = new Entities.Utilisateur()
            {
                Login = login,
                Password = EncodeSha1(login + ":" + password),
                Permissions = perm
            };
            businessLayer.Data.Utilisateurs.Add(user);
            businessLayer.Data.SaveChanges();
        }

        public Entities.Utilisateur Authentifier(string login, string password)
        {
            string hash = EncodeSha1(login + ":" + password);
            var user = from u in businessLayer.Data.Utilisateurs
                       where u.Login == login && u.Password == hash
                       select u;
            return user.FirstOrDefault();
        }

        public static string EncodeSha1(string str)
        {
            var sb = new StringBuilder();
            foreach (byte b in SHA1.Create().ComputeHash(Encoding.UTF8.GetBytes(str)))
                sb.Append(b.ToString("X2"));
            return sb.ToString();
        }
    }
}
