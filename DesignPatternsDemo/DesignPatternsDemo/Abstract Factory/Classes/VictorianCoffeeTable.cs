using DesignPatternsDemo.Abstract_Factory.Interfaces;

namespace DesignPatternsDemo.Abstract_Factory.Classes
{
    public class VictorianCoffeeTable : ICoffeeTable
    {
        public void PlaceItems()
        {
            Console.WriteLine("Placing items on a Victorian coffee table.");
        }
    }
}
