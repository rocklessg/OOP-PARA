namespace SolidPrinciple.InterfaceSegregation
{
    public interface ILivingthing
    {
        string Speak(string nature);
        bool GiveBirthToYoungerOnesAlive(string type);
    }
}
