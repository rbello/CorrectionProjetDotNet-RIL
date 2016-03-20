using Business;
using Business.Entities;
using System;
using System.Windows.Forms;

namespace Application
{
    public partial class LoginForm : Form
    {
        private BusinessLayer _business;
        private bool _debug;

        public LoginForm(BusinessLayer business, bool debug)
        {
            _business = business;
            _debug = debug;
            InitializeComponent();
            WarningLogin.Visible = false;
            WarningPassword.Visible = false;
            LoginTextBox.Select();
            if (debug)
            {
                LoginTextBox.Text = "admin";
                PasswordTextBox.Text = "admin";
            }
        }

        private void ConnexionButton_Click(object sender, EventArgs e)
        {
            // Reset
            InfoLabel.Text = "";
            WarningLogin.Visible = false;
            WarningPassword.Visible = false;
            // Disable button
            ConnexionButton.Enabled = false;
            // Check
            if (LoginTextBox.Text.Trim().Length < 3)
            {
                WarningLogin.Visible = true;
            }
            if (PasswordTextBox.Text.Trim().Length < 3)
            {
                WarningPassword.Visible = true;
            }
            // Auth
            if (!WarningLogin.Visible && !WarningPassword.Visible)
            {
                Utilisateur user = _business.GestionUtilisateurs.Authentifier(
                                        LoginTextBox.Text, PasswordTextBox.Text);
                if (user == null)
                {
                    InfoLabel.Text = "Erreur de login/password";
                }
                else
                {
                    Dispose();
                    Program.ShowMainForm(_business, user);
                }
            }
            // Enable button
            ConnexionButton.Enabled = true;
        }

    }
}
