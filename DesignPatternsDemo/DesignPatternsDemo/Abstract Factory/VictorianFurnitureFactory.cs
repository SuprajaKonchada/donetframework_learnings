using DesignPatternsDemo.Abstract_Factory.Classes;
using DesignPatternsDemo.Abstract_Factory.Interfaces;

namespace DesignPatternsDemo.Abstract_Factory
{
    public class VictorianFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new VictorianChair();
        }

        public ISofa CreateSofa()
        {
            return new VictorianSofa();
        }

        public ICoffeeTable CreateCoffeeTable()
        {
            return new VictorianCoffeeTable();
        }
    }
}
