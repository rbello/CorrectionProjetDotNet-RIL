using System;
using System.Linq;
using System.Windows.Forms;
using Business;
using Business.Entities;
using System.Drawing;

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
            UpdateData();

            // On masque les ID
            dataGridView1.Columns[0].Visible = false;

            // Edition du client
            dataGridView1.CellDoubleClick += this.EditClient;

            // Menu contextuel
            dataGridView1.MouseClick += this.DisplayContextMenu;

            // Focus sur le champ de recherche
            textBox1.Focus();
        }

        public void UpdateData()
        {
            // Données initiales non filtrées
            dataGridView1.DataSource = businessLayer.GestionClients.ListeClientsResumée().ToList();
        }

        private void DisplayContextMenu(object sender, MouseEventArgs evt)
        {
            if (evt.Button != MouseButtons.Right) return;
            int currentMouseOverRow = dataGridView1.HitTest(evt.X, evt.Y).RowIndex;
            if (currentMouseOverRow < 0) return;

            SelectRow(currentMouseOverRow);

            var m = new ContextMenu();
            var delete = new MenuItem(string.Format("Supprimer", currentMouseOverRow.ToString()));
            delete.Click += (src, e) =>
            {
                int id = (int)dataGridView1[0, currentMouseOverRow].Value;
                businessLayer.GestionClients.SupprimerClient(id);
                UpdateData();
            };
            m.MenuItems.Add(delete);

            m.Show(dataGridView1, new Point(evt.X, evt.Y));
        }

        public void SelectRow(int currentMouseOverRow)
        {
            DataGridViewCell c = dataGridView1[1, currentMouseOverRow];
            if (!c.Selected)
            {
                c.DataGridView.ClearSelection();
                c.DataGridView.CurrentCell = c;
                c.Selected = true;
            }
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
