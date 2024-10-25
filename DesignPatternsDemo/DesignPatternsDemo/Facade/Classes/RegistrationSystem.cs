namespace DesignPatternsDemo.Facade.Classes
{
    public class RegistrationSystem
    {
        public bool RegisterVehicle(string customerName, string vehicle)
        {
            Console.WriteLine($"Registering {vehicle} for {customerName}.");
            // Assume some logic to register the vehicle
            return true;
        }
    }

}
