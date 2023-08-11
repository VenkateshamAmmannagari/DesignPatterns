using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.HelperClasses
{
    internal class TermLoan : ILoan
    {
        public void GetDetails()
        {
            Console.WriteLine("Getting the details of Term loan ..!");
        }
    }
}
