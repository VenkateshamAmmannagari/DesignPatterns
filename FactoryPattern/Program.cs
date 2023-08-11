// See https://aka.ms/new-console-template for more information
using FactoryPattern;
using FactoryPattern.FactoryClass;

Console.WriteLine("Please enter the card type (Silver,Gold,Platinum) to know the details..!");
var cardtype = Console.ReadLine();
ICreditCard creditCard = CreditCardFactory.GetCreditCard(cardtype);
    if (creditCard != null)
    {
        Console.WriteLine($"Credit Card Type : {creditCard.GetCardType()}");
        Console.WriteLine($"Credit Card Limt : {creditCard.GetCardLimit()} INR");
        Console.WriteLine($"Credit Card Maintenance Charges: {creditCard.GetCardMaintenanceCharges()} INR");
    }
    else
        Console.WriteLine("Invalid Card");

Console.ReadLine();