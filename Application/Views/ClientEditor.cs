using System.Windows.Forms;
using Business.Entities;
using Business;
using System;
using System.Collections.Generic;

namespace Application.Views
{
    public partial class ClientEditor : UserControl
    {

        private Client client;
        private BusinessLayer business;

        public ClientEditor(BusinessLayer business)
        {
            this.business = business;
            InitializeComponent();
            comboCivilite.DataSource = new List<string>()
            {
                Civilite.Monsieur.ToString(),
                Civilite.Madame.ToString(),
                Civilite.Mademoiselle.ToString()
            };
            button1.Click += this.HandleSave;
            client = new Client();
            textNumeroClient.Text = Guid.NewGuid().ToString().ToUpper();
        }

        public ClientEditor(BusinessLayer business, Client client) : this(business)
        {
            this.client = client;

            labelTitre.Text = client.Prenom + " " + client.Nom;

            comboCivilite.SelectedIndex = (int) client.Civilite;
            textNom.Text = client.Nom;
            textPrenom.Text = client.Prenom;

            textEmail.Text = client.Email;
            textTelFixe.Text = client.TelFixe;
            textTelPortable.Text = client.TelPortable;

            textPays.Text = client.AdressePays;
            textVille.Text = client.AdresseVille;
            textCp.Text = client.AdresseCp;
            textAddr1.Text = client.Adresse1;
            textAddr2.Text = client.Adresse2;

            textEntreprise.Text = client.Entreprise;
            textNumeroClient.Text = client.NumeroCarteFidelite;
        }

        private void HandleSave(object sender, EventArgs e)
        {

            client.Civilite = (Civilite) Enum.Parse(typeof(Civilite), comboCivilite.Text);
            client.Nom = textNom.Text.Trim();
            client.Prenom = textPrenom.Text.Trim();

            client.Email = textEmail.Text.Trim();
            client.TelFixe = textTelFixe.Text.Trim();
            client.TelPortable = textTelPortable.Text.Trim();

            client.AdressePays = textPays.Text.Trim();
            client.AdresseVille = textVille.Text.Trim();
            client.AdresseCp = textCp.Text.Trim();
            client.Adresse1 = textAddr1.Text.Trim();
            client.Adresse2 = textAddr2.Text.Trim();

            client.Entreprise = textEntreprise.Text.Trim();
            client.NumeroCarteFidelite = textNumeroClient.Text.Trim();

            business.GestionClients.AjouterClient(client);

            ((MainForm)Parent.Parent).ChangeView(new ClientList(business));
        }

    }
}
