using AbstractFactoryPattern.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.FactoryClass
{
    internal class BankLoanFactory : IBankFactory
    {
        public IDeposit Deposits()
        {
            return new RegularDeposit();
        }

        public ILoan Loans()
        {
            return new RegularLoan();  
        }
    }
}
