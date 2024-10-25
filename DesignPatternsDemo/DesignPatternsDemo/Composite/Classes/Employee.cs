using DesignPatternsDemo.Composite.Interface;

namespace DesignPatternsDemo.Composite.Classes
{
    public class Employee : IEmployee
    {
        public string Name { get; set; }
        public string Position { get; set; }

        public Employee(string name, string position)
        {
            Name = name;
            Position = position;
        }

        public string GetDetails()
        {
            return $"{Name} works as a {Position}";
        }
    }

}
