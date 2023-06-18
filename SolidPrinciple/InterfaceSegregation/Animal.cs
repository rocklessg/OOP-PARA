namespace SolidPrinciple.InterfaceSegregation
{
    public class Animal : ILivingthing
    {
        public void Feed()
        {
            Console.WriteLine("All animals can feed");
        }

        public bool GiveBirthToYoungerOnesAlive(string type)
        {

            if (string.IsNullOrEmpty(type))
                return false;

            return type == "Mammals";
        }

        public string Grow()
        {
            return "All animals grow";
        }

        public string Speak(string nature)
        {
            if (string.IsNullOrEmpty(nature))
            {
                return "Invalid request";
            }
            return nature == "Homonsapient" ? $"{nature} can speak" : $"{nature} can not speak";
        }
    }
}
