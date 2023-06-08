using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            if (type == "Mammals")
            {
                return true;
            }
            else
            {
                return false;
            }
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

            if (nature == "Homonsapient")
            {
                return $"{nature} can speak";
            }
            return $"{nature} can not speak";
        }
    }
}
