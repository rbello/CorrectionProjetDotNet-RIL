using Application.Views;
using Business;
using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var debug = true;
            var b = new BusinessLayer();
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new LoginForm(b, debug));
        }

        internal static void ShowMainForm(BusinessLayer _business, Utilisateur user)
        {
            new Thread(() =>
            {
                System.Windows.Forms.Application.Run(new MainForm(_business, user));
            }).Start();
        }
    }
}
