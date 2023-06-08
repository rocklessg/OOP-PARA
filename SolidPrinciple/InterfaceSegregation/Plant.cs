using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple.InterfaceSegregation
{
    public class Plant : ILivingthing
    {
        public void Feed()
        {
            Console.WriteLine("All plants takes in nutrient") ;
        }

        public bool GiveBirthToYoungerOnesAlive(string type)
        {
            throw new NotImplementedException();
        }

        public string Grow()
        {
            return "Plants grow and some grows tall";
        }

        public string Speak(string nature)
        {
            throw new NotImplementedException();
        }
    }
}
