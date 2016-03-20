using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application.Views
{
    public partial class CustomerPanel : UserControl
    {
        public CustomerPanel(Business.BusinessLayer businessLayer)
        {
            InitializeComponent();

            // Sélection des lignes entières
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Ajustement des colonnes en largeur
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Utilisation du champ de recherche
            EventHandler handler = (src, evt) =>
            {
                // Données filtrées
                dataGridView1.DataSource = businessLayer.GestionClients.ListeClientsResumée(textBox1.Text.Trim()).ToList();
            };
            textBox1.TextChanged += handler;
            button1.Click += handler;

            // Données initiales non filtrées
            dataGridView1.DataSource = businessLayer.GestionClients.ListeClientsResumée().ToList();

            // Focus sur le champ de recherche
            textBox1.Focus();
        }
    }
}
