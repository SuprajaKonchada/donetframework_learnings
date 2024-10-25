namespace DesignPatternsDemo.Builder.Classes
{
    public class HouseDirector
    {
        private HouseBuilder _houseBuilder;

        public HouseDirector(HouseBuilder houseBuilder)
        {
            _houseBuilder = houseBuilder;
        }

        public void ConstructHouse()
        {
            _houseBuilder.BuildWalls();
            _houseBuilder.BuildFloor();
            _houseBuilder.InstallDoor();
            _houseBuilder.FitWindows();
            _houseBuilder.BuildRoof();
        }

        public House GetConstructedHouse()
        {
            return _houseBuilder.GetHouse();
        }
    }
}
