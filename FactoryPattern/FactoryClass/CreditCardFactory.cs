using FactoryPattern.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.FactoryClass
{
    internal class CreditCardFactory
    {
        public static ICreditCard GetCreditCard(string CardType)
        {
            ICreditCard creditCard = null;

            switch (CardType)
            {
                case "Silver":
                    creditCard = new SilverCreditCard();
                    break;
                case "Gold":
                    creditCard = new GoldCreditCard();
                    break;
                case "Platinum":
                    creditCard = new PlatinumCreditCard();
                    break;
                default:
                    break;
            }
            return creditCard;
        }
    }
}
