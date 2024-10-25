using DesignPatternsDemo.Decorator.Interface;

namespace DesignPatternsDemo.Decorator.Classes
{
    public class SportsPackage : CarDecorator
    {
        public SportsPackage(ICar car) : base(car)
        {
        }

        public override string GetDescription()
        {
            return _car.GetDescription() + ", Sports Package";
        }

        public override double GetCost()
        {
            return _car.GetCost() + 5000;
        }
    }

}
