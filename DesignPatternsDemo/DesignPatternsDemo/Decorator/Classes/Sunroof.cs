using DesignPatternsDemo.Decorator.Interface;

namespace DesignPatternsDemo.Decorator.Classes
{
    public class Sunroof : CarDecorator
    {
        public Sunroof(ICar car) : base(car)
        {
        }

        public override string GetDescription()
        {
            return _car.GetDescription() + ", Sunroof";
        }

        public override double GetCost()
        {
            return _car.GetCost() + 1500;
        }
    }

}
