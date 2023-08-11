using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal interface ICreditCard
    {
        String GetCardType();
        int GetCardLimit();
        int GetCardMaintenanceCharges();
    }
}
