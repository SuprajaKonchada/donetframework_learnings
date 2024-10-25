using DesignPatternsDemo.Decorator.Interface;

namespace DesignPatternsDemo.Decorator.Classes
{
    public class BasicCar : ICar
    {
        public string GetDescription()
        {
            return "Basic Car";
        }

        public double GetCost()
        {
            return 25000;
        }
    }

}
