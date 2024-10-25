namespace DesignPatternsDemo.Builder.Classes
{
    public class SimpleHouseBuilder : HouseBuilder
    {
        public override void BuildWalls()
        {
            house.Walls = "4 brick walls";
        }

        public override void BuildFloor()
        {
            house.Floor = "Wooden floor";
        }

        public override void InstallDoor()
        {
            house.Door = "1 wooden door";
        }

        public override void FitWindows()
        {
            house.Windows = "2 glass windows";
        }

        public override void BuildRoof()
        {
            house.Roof = "Sloped roof";
        }
    }
}
