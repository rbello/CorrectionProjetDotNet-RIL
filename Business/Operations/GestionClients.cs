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

        public Client AjouterClient(Civilite civilite, string prenom, string nom, string email, string telPortable, string telFixe, string pays, string ville, string codePostal, string addr1, string addr2 = "", string entreprise = "")
        {
            return AjouterClient(new Entities.Client()
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
            });
        }

        public Client AjouterClient(Client client)
        {
            businessLayer.Data.Clients.Add(client);
            businessLayer.Data.SaveChanges();
            return client;
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

        public IQueryable<object> ListeClientsResumée(string match)
        {
            match = match.ToUpper();
            return from c in businessLayer.Data.Clients
                   where c.Prenom.ToUpper().Contains(match) || c.Nom.ToUpper().Contains(match)
                         || c.Email.ToUpper().Contains(match) || c.TelFixe.ToUpper().Contains(match)
                         || c.TelPortable.ToUpper().Contains(match) || c.AdresseVille.ToUpper().Contains(match)
                         || c.AdresseCp.ToUpper().Contains(match) || c.AdressePays.ToUpper().Contains(match)
                   select new
                   {
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
