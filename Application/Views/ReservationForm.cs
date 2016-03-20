using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Application.Views
{
    public partial class ReservationForm : UserControl
    {
        public ReservationForm(Business.BusinessLayer businessLayer)
        {
            InitializeComponent();


            var list = new List<string>() { "" };
            list.AddRange(businessLayer.GestionClients.ListeNomsClients());
            //comboBox1.DataSource = list;

            comboBox1.TextChanged += (src, evt) =>
            {
                var txt = comboBox1.Text.ToUpper();
                var copy = (from i in list where i.ToUpper().Contains(txt) select i).ToList();
                copy.Insert(0, comboBox1.Text);
                comboBox1.DataSource = copy;
                comboBox1.SelectionStart = txt.Length;
                if (copy.Count > 1)
                {
                    comboBox1.DroppedDown = true;
                }
            };
        }
    }
}
