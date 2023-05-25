using System.Text;

namespace Model
{
    public class BankAccount
    {
        private static int accountNumberSeed = 1234567890;

        public string  AccountNumber{ get; set; }
        public string AccountOwner { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }

        public BankAccount(string accountOwner, decimal initialBalance)
        {
            AccountOwner = accountOwner;
            AccountNumber = accountNumberSeed.ToString();
            accountNumberSeed++;
            MakeDeposite(initialBalance, DateTime.UtcNow, "Initial balance");
        }

        private List<Transaction> allTransactions = new();

        public void MakeDeposite(decimal amount, DateTime date, string narration)
        {
            try
            {
                if (amount <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(amount), "Deposite amount must be positive");
                }

                var deposite = new Transaction(amount, date, narration);
                allTransactions.Add(deposite);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string narration)
        {
            try
            {
                if (amount <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(amount), "Deposite amount must be positive");
                }
                if (Balance - amount < 0)
                {
                    throw new InvalidOperationException("Insufficient fund");
                }
                var withdraw = new Transaction(-amount, date, narration);
                allTransactions.Add(withdraw);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public string GetAccountHistory()
        {
            var report = new StringBuilder();
            report.AppendLine("Date\t\tAmount\tBalance");
            decimal balance = 0;

            foreach (var transaction in allTransactions)
            {
                balance += transaction.Amount;
                report.AppendLine($"{transaction.Date.ToShortDateString()}\t{transaction.Amount}\t{transaction.Narration}");
            }
            return report.ToString();
        }
    }
}