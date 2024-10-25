using DesignPatternsDemo.Abstract_Factory.Interfaces;

namespace DesignPatternsDemo.Abstract_Factory.Classes
{
    public class ArtDecoChair : IChair
    {
        public void SitOn()
        {
            Console.WriteLine("Sitting on an ArtDeco chair.");
        }
    }
}
