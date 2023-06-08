namespace SolidPrinciple.InterfaceSegregation
{
    public class Plant : IPlant
    {
        public void Feed()
        {
            Console.WriteLine("All plants takes in nutrient") ;
        }
        public string Grow()
        {
            return "Plants grow and some grows tall";
        }
    }
}
