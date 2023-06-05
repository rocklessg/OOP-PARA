namespace SolidPrinciple.OpenClose
{
    public class Current : Account
    {
        public override string AccountOperation(string accountType)
        {
            return base.AccountOperation("Current");
        }
    }
}
