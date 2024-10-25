namespace DesignPatternsDemo.Facade.Classes
{
    public class CreditSystem
    {
        public bool CheckCreditScore(string customerName)
        {
            Console.WriteLine($"Checking credit score for {customerName}.");
            // Assume some logic to check credit score
            return true;
        }
    }

}
