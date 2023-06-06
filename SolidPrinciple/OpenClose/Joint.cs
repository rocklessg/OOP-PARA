using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple.OpenClose
{
    public class Joint : Account
    {
        public override string AccountOperation(string accountType)
        {
            return base.AccountOperation("Joint");
        }
    }
}
