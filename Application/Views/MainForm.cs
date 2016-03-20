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

            //UserLabel.Text = "Hello " + user.Login + " (" + user.GetUserType() + ")";
           /* buttonChooseCustomers.Click += (evt, target) => {

            };*/

        }
    }
}
