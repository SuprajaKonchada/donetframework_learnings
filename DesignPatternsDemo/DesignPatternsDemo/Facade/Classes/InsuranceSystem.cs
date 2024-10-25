namespace DesignPatternsDemo.Facade.Classes
{
    public class InsuranceSystem
    {
        public bool ProvideInsurance(string customerName)
        {
            Console.WriteLine($"Providing insurance for {customerName}.");
            // Assume some logic to provide insurance
            return true;
        }
    }

}
