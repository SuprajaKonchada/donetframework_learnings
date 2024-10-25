namespace DesignPatternsDemo.Builder.Classes
{
    public abstract class HouseBuilder
    {
        protected House house = new House();

        public abstract void BuildWalls();
        public abstract void BuildFloor();
        public abstract void InstallDoor();
        public abstract void FitWindows();
        public abstract void BuildRoof();

        public House GetHouse()
        {
            return house;
        }
    }
}
