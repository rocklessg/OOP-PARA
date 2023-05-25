using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class LineOfCreditAccount : BankAccount
    {

        public LineOfCreditAccount(string accountOwner, decimal initialDeposite) : base(accountOwner, initialDeposite)
        {

        }

        public override void PerformMonthEndTransactions()
        {
            if (Balance < 0)
            {
                // Negate the balance to get a positive interest charge
                decimal interest = -Balance * 0.07m;
                MakeWithdrawal(interest, DateTime.UtcNow, "Charge Monthly interest");
            }
        }
    }
}
