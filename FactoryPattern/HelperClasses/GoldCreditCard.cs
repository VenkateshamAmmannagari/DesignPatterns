using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.HelperClasses
{
    internal class GoldCreditCard : ICreditCard
    {
        public int GetCardLimit()
        {
            return 200000;
        }

        public int GetCardMaintenanceCharges()
        {
            return 800;
        }

        public string GetCardType()
        {
            return "Gold";
        }
    }
}
