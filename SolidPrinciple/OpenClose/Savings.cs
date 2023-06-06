namespace SolidPrinciple.OpenClose
{
    public class Savings : Account
    {
        public override string AccountOperation(string accountType)
        {
            return base.AccountOperation("Savings");
        }
    }
}
