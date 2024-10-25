namespace DesignPatternsDemo.Facade.Classes
{
    public class LoanSystem
    {
        public bool CheckLoanEligibility(string customerName)
        {
            Console.WriteLine($"Checking loan eligibility for {customerName}.");
            // Assume some logic to check loan eligibility
            return true;
        }
    }

}
