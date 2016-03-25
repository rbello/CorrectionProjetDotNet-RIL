﻿using Business;
using Business.Entities;
using System.Windows.Forms;

namespace Application.Views
{
    public partial class MainForm : Form
    {
        public MainForm(BusinessLayer businessLayer, Utilisateur user)
        {
            InitializeComponent();

            InfoLabel.Text = "Hello " + user.Login + " (" + user.GetUserType() + ")";

            var tab1 = new RibbonTab()
            {
                Text = "Test"
            };
            RibbonPanel.Tabs.Add(tab1);

            {
                var panel1 = new RibbonPanel()
                {
                    Text = "Vues"
                };
                tab1.Panels.Add(panel1);
                {
                    var button1 = new RibbonButton()
                    {
                        Text = "Clients",
                        Image = global::Application.Properties.Resources.ImageUserAdd
                    };
                    button1.Click += (evt, src) =>
                    {
                        ChangeView(new ClientList(businessLayer)
                        {
                            Dock = DockStyle.Fill
                        });
                    };
                    panel1.Items.Add(button1);
                    var button2 = new RibbonButton()
                    {
                        Text = "Reservation",
                        Image = global::Application.Properties.Resources.ImageUserAdd
                    };
                    button2.Click += (evt, src) =>
                    {
                        ChangeView(new ReservationForm(businessLayer)
                        {
                            Dock = DockStyle.Fill
                        });
                    };
                    panel1.Items.Add(button2);
                }
            }

        }

        public void ChangeView(Control ctrl)
        {
            ctrl.Dock = DockStyle.Fill;
            CenterArea.Controls.Clear();
            CenterArea.Controls.Add(ctrl);
        }
    }
}
