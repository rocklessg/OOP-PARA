// See https://aka.ms/new-console-template for more information
using Model;

Console.WriteLine("Hello, World!");

var account = new BankAccount("Abdulhafiz", 2000);
var account1 = new BankAccount("Abdulhafiz", 10000);

Console.WriteLine($"Welcome {account.AccountOwner}, Your account number is {account.AccountNumber} and you have {account.Balance} initial balance");
Console.WriteLine($"Welcome {account.AccountOwner}, Your account number is {account1.AccountNumber} and you have {account1.Balance} initial balance");

account.MakeDeposite(10000, DateTime.UtcNow, "Food fund");
Console.WriteLine(account.Balance);
account.MakeWithdrawal(1000, DateTime.UtcNow, "Passport fund");
Console.WriteLine(account.Balance);

Console.WriteLine(account.GetAccountHistory());