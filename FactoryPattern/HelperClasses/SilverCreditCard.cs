using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.HelperClasses
{
    internal class SilverCreditCard:ICreditCard
    {
        public int GetCardLimit()
        {
            return 100000;
        }

        public int GetCardMaintenanceCharges()
        {
            return 500;
        }

        public string GetCardType()
        {
            return "Silver";
        }
    }
}
