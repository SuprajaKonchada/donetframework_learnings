using DesignPatternsDemo.Abstract_Factory.Interfaces;

namespace DesignPatternsDemo.Abstract_Factory.Classes
{
    public class ModernSofa : ISofa
    {
        public void LieOn()
        {
            Console.WriteLine("Lying on a modern sofa.");
        }
    }
}
