using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple.OpenClose
{
    public class Account
    {
        private int AccountNumberSeed = 1234567890;

        public int Id { get; set; }
        public string Name { get; set; }
        public int  Age { get; set; }
        public AccountType AccountType { get; set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }

        public Account()
        {
            AccountNumber = AccountNumberSeed.ToString();
            AccountNumberSeed++;
        }

        public string OpenAccount(int Id, Account account)
        {
            var createAccount = new Account()
            {
                Id = Id,
                Name = account.Name,
                AccountType = AccountType,
                Balance = account.Balance,
                CreatedAt = DateTime.UtcNow,
                ModifiedAt = DateTime.UtcNow
            };
            return $"Congratulations {createAccount.Name}! Your {createAccount.AccountType} account is opened successfully";
        }

        public string AccountOperation(AccountType accountType)
        {
            // This code will continue expanding as the account types increases
            // This violates open close principle

            if (accountType == AccountType.Current)
            {
                // Code for actions allowed for the account type
                return $"{accountType} account actions set successfully";
            }
            else if (accountType == AccountType.Savings)
            {
                // Code for actions allowed for the account type
                return $"{accountType} account actions set successfully";
            }
            else if (accountType == AccountType.Joint)
            {
                // Code for actions allowed for the account type
                return $"{accountType} account actions set successfully";
            }
            else
            {
                // Code for actions allowed for the account type
                return $"{accountType} account actions set successfully";
            }
        }
    }

    public enum AccountType
    {
        Savings,
        Current,
        // Joint and kids account type to be added later to see how the programm
        // handles extensions and modifications
        Joint,
        Kids
    }
}
