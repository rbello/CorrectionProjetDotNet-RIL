using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Operations
{
    public class GestionClients
    {
        private BusinessLayer businessLayer;

        public GestionClients(BusinessLayer businessLayer)
        {
            this.businessLayer = businessLayer;
        }
    }
}
