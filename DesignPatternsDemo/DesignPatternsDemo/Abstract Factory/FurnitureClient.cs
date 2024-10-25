using DesignPatternsDemo.Abstract_Factory.Interfaces;

namespace DesignPatternsDemo.Abstract_Factory
{
    class FurnitureClient
    {
        private IChair _chair;
        private ISofa _sofa;
        private ICoffeeTable _coffeeTable;

        public FurnitureClient(IFurnitureFactory factory)
        {
            _chair = factory.CreateChair();
            _sofa = factory.CreateSofa();
            _coffeeTable = factory.CreateCoffeeTable();
        }

        public void DescribeFurniture()
        {
            _chair.SitOn();
            _sofa.LieOn();
            _coffeeTable.PlaceItems();
        }
    }
}
