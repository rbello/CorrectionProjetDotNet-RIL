using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using System.Data.Entity;

namespace Business.Operations
{
    public class GestionClients
    {
        private BusinessLayer businessLayer;

        public GestionClients(BusinessLayer businessLayer)
        {
            this.businessLayer = businessLayer;
        }

        public void AjouterClient(Civilite civilite, string prenom, string nom, string email, string telPortable, string telFixe, string pays, string ville, string codePostal, string addr1, string addr2 = "", string entreprise = "")
        {
            var client = new Entities.Client()
            {
                Civilite = civilite,
                Nom = nom,
                Prenom = prenom,
                Email = email,
                TelPortable = telPortable,
                TelFixe = telFixe,
                AdressePays = pays,
                AdresseVille = ville,
                AdresseCp = codePostal,
                Adresse1 = addr1,
                Adresse2 = addr2,
                Entreprise = entreprise
            };
            businessLayer.Data.Clients.Add(client);
            businessLayer.Data.SaveChanges();
        }

        public IQueryable<string> ListeNomsClients()
        {
            
            return (from c in businessLayer.Data.Clients
                   select new {
                       Name = c.Civilite.ToString() + " " + c.Prenom + " " + c.Nom.ToUpper() + " (" + c.Id + ")"
                   }).Select(e => e.Name);
        }

        public IQueryable<object> ListeClientsResumée()
        {
            return from c in businessLayer.Data.Clients
                         select new {
                             Nom = c.Civilite.ToString() + " " + c.Prenom + " " + c.Nom.ToUpper(),
                             c.Email,
                             c.TelPortable,
                             c.TelFixe,
                             Région = c.AdresseCp + " " + c.AdresseVille + " (" + c.AdressePays + ")",
                             Réservations = (
                                from f in businessLayer.Data.Factures
                                where f.Client == c
                                select f).Count()
                         };
        }
    }
}
