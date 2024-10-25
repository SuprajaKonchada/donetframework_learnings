using DesignPatternsDemo.Abstract_Factory.Interfaces;

namespace DesignPatternsDemo.Abstract_Factory.Classes
{
    public class VictorianSofa : ISofa
    {
        public void LieOn()
        {
            Console.WriteLine("Lying on a Victorian sofa.");
        }
    }
}
