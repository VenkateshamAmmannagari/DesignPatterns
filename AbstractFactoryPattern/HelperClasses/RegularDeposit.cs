using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.HelperClasses
{
    internal class RegularDeposit : IDeposit
    {
        public void GetDetails()
        {
            Console.WriteLine("Getting detilas of Regular deposits ..!");
        }
    }
}
