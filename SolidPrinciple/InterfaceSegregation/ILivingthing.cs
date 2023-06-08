using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple.InterfaceSegregation
{
    public interface ILivingthing
    {
        string Speak(string nature);
        string Grow();
        void Feed();
        bool GiveBirthToYoungerOnesAlive(string type);
    }
}
