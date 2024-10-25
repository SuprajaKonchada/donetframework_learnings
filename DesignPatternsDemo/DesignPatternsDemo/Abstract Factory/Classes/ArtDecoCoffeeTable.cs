using DesignPatternsDemo.Abstract_Factory.Interfaces;

namespace DesignPatternsDemo.Abstract_Factory.Classes
{
    public class ArtDecoCoffeeTable : ICoffeeTable
    {
        public void PlaceItems()
        {
            Console.WriteLine("Placing items on an ArtDeco coffee table.");
        }
    }
}