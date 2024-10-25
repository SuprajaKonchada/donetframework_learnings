using DesignPatternsDemo.Composite.Interface;

namespace DesignPatternsDemo.Composite.Classes
{
    public class Manager : IEmployee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        private List<IEmployee> _subordinates;

        public Manager(string name, string position)
        {
            Name = name;
            Position = position;
            _subordinates = new List<IEmployee>();
        }

        // Add a subordinate (either an Employee or another Manager)
        public void AddSubordinate(IEmployee employee)
        {
            _subordinates.Add(employee);
        }

        // Remove a subordinate
        public void RemoveSubordinate(IEmployee employee)
        {
            _subordinates.Remove(employee);
        }

        // Get details of the manager and their subordinates
        public string GetDetails()
        {
            string details = $"{Name} works as a {Position} and manages the following employees:\n";
            foreach (var employee in _subordinates)
            {
                details += "  - " + employee.GetDetails() + "\n";
            }
            return details;
        }
    }

}
