using DesignPatternsDemo.Abstract_Factory.Interfaces;

namespace DesignPatternsDemo.Abstract_Factory.Classes
{
    public class ModernCoffeeTable : ICoffeeTable
    {
        public void PlaceItems()
        {
            Console.WriteLine("Placing items on a modern coffee table.");
        }
    }
}
