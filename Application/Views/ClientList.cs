using System;
using System.Linq;
using System.Windows.Forms;
using Business;
using Business.Entities;

namespace Application.Views
{
    public partial class ClientList : UserControl
    {

        private BusinessLayer businessLayer;

        public ClientList(Business.BusinessLayer businessLayer)
        {
            InitializeComponent();

            this.businessLayer = businessLayer;

            // Sélection des lignes entières
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Ajustement des colonnes en largeur
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Utilisation du champ de recherche
            textBox1.TextChanged += (src, evt) =>
            {
                // Données filtrées
                dataGridView1.DataSource = businessLayer.GestionClients.ListeClientsResumée(textBox1.Text.Trim()).ToList();
            };
            
            // Utilisation du bouton ajouter
            button1.Click += (src, evt) =>
            {
                ((MainForm)Parent.Parent).ChangeView(new ClientEditor(businessLayer));
            };

            // Données initiales non filtrées
            dataGridView1.DataSource = businessLayer.GestionClients.ListeClientsResumée().ToList();

            // Gestionnaire d'events
            dataGridView1.CellDoubleClick += this.EditClient;

            // On masque les ID
            dataGridView1.Columns[0].Visible = false;

            // Focus sur le champ de recherche
            textBox1.Focus();
        }

        private void EditClient(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int) dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            Client client = businessLayer.GestionClients.GetClientById(id);
            MainForm parent = (MainForm) Parent.Parent;
            parent.ChangeView(new ClientEditor(businessLayer, client));
        }
    }
}
