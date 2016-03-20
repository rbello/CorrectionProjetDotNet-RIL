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

            dataGridView1.DataSource = businessLayer.GestionClients.ListeClientsResumée().ToList();
        }
    }
}
