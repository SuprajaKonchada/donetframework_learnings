using DesignPatternsDemo.Strategy.Interfaces;

namespace DesignPatternsDemo.Strategy
{
    public class PaymentProcessor
    {
        private IPaymentStrategy paymentStrategy;

        // Set the strategy at runtime
        public void SetPaymentMethod(IPaymentStrategy strategy)
        {
            this.paymentStrategy = strategy;
        }

        // Execute the payment
        public void Pay(double amount)
        {
            if (paymentStrategy == null)
            {
                Console.WriteLine("Please select a payment method.");
            }
            else
            {
                paymentStrategy.Pay(amount);
            }
        }
    }

}
