using SolidPrinciple.Liskov_LSP_;

namespace SolidPrinciple
{
    //Violation of Liskov substitution principle
    //public class Apple
    //{
    //    public virtual string GetColor() => "Red";
    //}

    //public class Orange : Apple
    //{
    //    public override string GetColor() => "Orange";
    //}


    //Obey Liskov substitution principle
    public class Apple : IFruit
    {
        public string GetColor() => "Red";
    }

    public class Orange : IFruit
    {
        public string GetColor() => "Orange";
    }
}