using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.HelperClasses
{
    internal class PlatinumCreditCard : ICreditCard
    {
        public int GetCardLimit()
        {
            return 500000;
        }

        public int GetCardMaintenanceCharges()
        {
            return 1000;
        }

        public string GetCardType()
        {
            return "Platinum";
        }
    }
}
