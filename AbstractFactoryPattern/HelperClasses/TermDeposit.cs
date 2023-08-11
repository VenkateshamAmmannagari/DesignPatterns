using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.HelperClasses
{
    internal class TermDeposit : IDeposit
    {
        public void GetDetails()
        {
            Console.WriteLine("Getting details of Term deposits ..!");
        }
    }
}
