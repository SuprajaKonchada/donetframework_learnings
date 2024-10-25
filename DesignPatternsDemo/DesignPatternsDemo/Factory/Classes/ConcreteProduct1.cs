using DesignPatternsDemo.Factory.Interfaces;

namespace DesignPatternsDemo.Factory.Classes
{
    class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct1}";
        }
    }
}
