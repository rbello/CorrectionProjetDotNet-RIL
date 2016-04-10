using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;

namespace Application.Views
{
    public partial class PlanningForm : UserControl
    {
        private Business.BusinessLayer businessLayer;

        public PlanningForm(Business.BusinessLayer businessLayer)
        {
            InitializeComponent();
            this.businessLayer = businessLayer;

            // Ajustement des colonnes en largeur
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Gestionnaire d'event
            monthCalendar1.DateSelected += this.DateSelectionChanged;

            // Max de jour sélectionnables
            monthCalendar1.MaxSelectionCount = 15;

            // On affiche au début les 7 prochains jours
            monthCalendar1.SelectionRange = new SelectionRange(DateTime.Now, DateTime.Now.AddDays(7));

        }

        private void DateSelectionChanged(object sender, DateRangeEventArgs e)
        {
            SelectDateRange(e.Start, e.End);
        }

        public void SelectDateRange(DateTime start, DateTime end)
        {

            var dt = new DataTable();
            var label = "Chambre";
            dt.Columns.Add(label, typeof(String));

            DateTime[] days = new DateTime[(int)Math.Ceiling((end - start).TotalDays)];

            for (int i = 0; i < days.Length; ++i) {
                days[i] = start.AddDays(i);
                dt.Columns.Add(days[i].ToString("dddd dd/MM/yy"), typeof(String));
            }

            foreach (Chambre room in businessLayer.GestionHotel.GetChambresDisponibles(true))
            {
                DataRow row = dt.NewRow();
                int i = 0;
                foreach (DataColumn col in dt.Columns)
                {
                    if (i == 0)
                    {
                        row[col] = room.Numero;
                    }
                    else
                    {
                        Reservation r = businessLayer.GestionReservations.GetReservation(room, days[i-1]);
                        if (r == null)
                        {
                            row[col] = "";
                        }
                        else
                        {
                            row[col] = "X";
                        }
                    }
                    ++i;
                }
                dt.Rows.Add(row);
            }
            dataGridView1.DataSource = dt;
        }

    }
}
