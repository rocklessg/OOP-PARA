using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple.OpenClose
{
    public class Account
    {
        private readonly int AccountNumberSeed = 1234567890;

        public int Id { get; set; }
        public string Name { get; set; }
        public int  Age { get; set; }
        public string AccountType { get; set; }
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
                AccountType = account.AccountType,
                Balance = account.Balance,
                CreatedAt = DateTime.UtcNow,
                ModifiedAt = DateTime.UtcNow
            };
            return $"Congratulations {createAccount.Name}! Your {createAccount.AccountType} account is opened successfully";
        }

        public virtual string AccountOperation(string accountType)
        {
            return $"{accountType} account actions set successfully";
        }
    }
}
