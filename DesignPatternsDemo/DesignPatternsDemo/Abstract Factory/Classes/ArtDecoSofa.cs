using DesignPatternsDemo.Abstract_Factory.Interfaces;

namespace DesignPatternsDemo.Abstract_Factory.Classes
{
    public class ArtDecoSofa : ISofa
    {
        public void LieOn()
        {
            Console.WriteLine("Lying on an ArtDeco sofa.");
        }
    }
}
