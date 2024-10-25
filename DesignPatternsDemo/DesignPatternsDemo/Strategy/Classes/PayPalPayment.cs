using DesignPatternsDemo.Strategy.Interfaces;

namespace DesignPatternsDemo.Strategy.Classes
{
    public class PayPalPayment : IPaymentStrategy
    {
        private string email;

        public PayPalPayment(string email)
        {
            this.email = email;
        }

        public void Pay(double amount)
        {
            Console.WriteLine($"Paid {amount} using PayPal. Email: {email}");
        }
    }

}
