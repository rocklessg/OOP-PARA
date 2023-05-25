using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class InterestEarningAccount : BankAccount
    {

        public InterestEarningAccount(string accountOwner, decimal initialDeposite) : base(accountOwner, initialDeposite)
        {

        }

        public override void PerformMonthEndTransactions()
        {
            if (Balance > 500m)
            {
                decimal interest = Balance * 0.05m;
                MakeDeposite(interest, DateTime.UtcNow, "Pay Monthly interest");
            }
        }

    }

}
