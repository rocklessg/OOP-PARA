// See https://aka.ms/new-console-template for more information
using Model;
using SolidPrinciple;
using SolidPrinciple.InterfaceSegregation;
using SolidPrinciple.Liskov_LSP_;
using SolidPrinciple.OpenClose;
using SolidPrinciple.SingleResponsibility;

//Console.WriteLine("Hello, World!");

//var account = new BankAccount("Abdulhafiz", 2000);
//var account1 = new BankAccount("Abdulhafiz", 10000);

//Console.WriteLine($"Welcome {account.AccountOwner}, Your account number is {account.AccountNumber} and you have {account.Balance} initial balance");
//Console.WriteLine($"Welcome {account.AccountOwner}, Your account number is {account1.AccountNumber} and you have {account1.Balance} initial balance");

//account.MakeDeposite(10000, DateTime.UtcNow, "Food fund");
//Console.WriteLine(account.Balance);
//account.MakeWithdrawal(1000, DateTime.UtcNow, "Passport fund");
//Console.WriteLine(account.Balance);

//Console.WriteLine(account.GetAccountHistory());

//Apple apple = new Orange();
//Console.WriteLine(apple.GetColor()); // this returns Orange instead of Red color of the Apple(behaviour of apple change)

//IFruit fruit = new Orange();
//Console.WriteLine($"Color of Orange is: {fruit.GetColor()}");
//fruit =  new Apple();   // These obeys LISKOV
//Console.WriteLine($"Color of Apple is: {fruit.GetColor()}");

//User user = new();
//var displayResult = user.AddUser(1, "user@email.com");
//Console.WriteLine(displayResult);

////OCP Correct
//Account account = new()
//{
//    Id = 1,
//    Name = "Test",
//    Balance = 200,
//    AccountType = "Savings"
//};
//var displayResult = account.OpenAccount(1, account);
//Console.WriteLine(displayResult);

//Savings savings = new ();
//var accountOperation = savings.AccountOperation(account.AccountType);
//Console.WriteLine(accountOperation);

//IFruit fruit = new Orange();
//Console.WriteLine(fruit.GetColor());

//fruit = new Apple();
//Console.WriteLine(fruit.GetColor());

ILivingthing animal = new Animal();
IPlant animals = new Animal();
IPlant plant = new Plant();
Console.WriteLine(animal.GiveBirthToYoungerOnesAlive("Mammals"));
animals.Feed();
plant.Feed();