// See https://aka.ms/new-console-template for more information
using AbstractFactoryPattern;
using AbstractFactoryPattern.FactoryClass;

IBankFactory bankDeposit = new BankDepositFactory();
IDeposit regualarDeposits =  bankDeposit.Deposits();
regualarDeposits.GetDetails();
ILoan homeLoans = bankDeposit.Loans();
homeLoans.GetDetails();

IBankFactory bankLoan = new BankLoanFactory();
IDeposit termDeposits = bankLoan.Deposits();
termDeposits.GetDetails();
ILoan PersonalLoans = bankLoan.Loans();
PersonalLoans.GetDetails();

Console.ReadLine();