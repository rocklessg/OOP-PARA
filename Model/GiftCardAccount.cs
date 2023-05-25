using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class GiftCardAccount : BankAccount
    {
        private readonly decimal _monthlyDeposit = 0m;

        public GiftCardAccount(string accountOwner, decimal initialDeposite, decimal monthlyDeposit = 0) :
            base(accountOwner, initialDeposite) => _monthlyDeposit = monthlyDeposit;

        public override void PerformMonthEndTransactions()
        {
            if (_monthlyDeposit != 0)
            {
                decimal interest = Balance * 0.05m;
                MakeDeposite(_monthlyDeposit, DateTime.UtcNow, "Add monthly deposit");
            }
        }
    }
}
