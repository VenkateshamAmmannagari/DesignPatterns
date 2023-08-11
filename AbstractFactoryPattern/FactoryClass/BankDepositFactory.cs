using AbstractFactoryPattern.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.FactoryClass
{
    internal class BankDepositFactory : IBankFactory
    {
        public IDeposit Deposits()
        {
            return new TermDeposit();
        }

        public ILoan Loans()
        {
            return new TermLoan();
        }
    }
}
