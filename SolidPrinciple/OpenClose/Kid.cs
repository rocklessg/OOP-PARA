namespace SolidPrinciple.OpenClose
{
    public class Kid : Account
    {
        public override string AccountOperation(string accountType)
        {
            return base.AccountOperation("Kid");
        }
    }
}
