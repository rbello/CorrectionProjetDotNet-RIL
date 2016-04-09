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
    public partial class PlanningForm : UserControl
    {
        private Business.BusinessLayer businessLayer;

        public PlanningForm(Business.BusinessLayer businessLayer)
        {
            InitializeComponent();
            this.businessLayer = businessLayer;
        }

    }
}
