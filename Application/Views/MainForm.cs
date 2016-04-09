using Business;
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
                        Text = "Réservations",
                        Image = global::Application.Properties.Resources.ImageAgenda32
                    };
                    button1.Click += (evt, src) =>
                    {
                        ChangeView(new PlanningForm(businessLayer));
                    };
                    panel1.Items.Add(button1);

                    var button2 = new RibbonButton()
                    {
                        Text = "Clients",
                        Image = global::Application.Properties.Resources.ImageCustomers32
                    };
                    button2.Click += (evt, src) =>
                    {
                        ChangeView(new ClientList(businessLayer));
                    };
                    panel1.Items.Add(button2);

                    var button3 = new RibbonButton()
                    {
                        Text = "Nouvelle Reservation",
                        Image = global::Application.Properties.Resources.ImageAdd32
                    };
                    button3.Click += (evt, src) =>
                    {
                        ChangeView(new ReservationForm(businessLayer));
                    };
                    panel1.Items.Add(button3);
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
