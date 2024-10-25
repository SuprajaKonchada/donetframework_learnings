using DesignPatternsDemo.Strategy.Interfaces;
namespace DesignPatternsDemo.Strategy.Classes
{
    public class CreditCardPayment : IPaymentStrategy
    {
        private string cardNumber;
        private string cardHolderName;

        public CreditCardPayment(string cardNumber, string cardHolderName)
        {
            this.cardNumber = cardNumber;
            this.cardHolderName = cardHolderName;
        }

        public void Pay(double amount)
        {
            Console.WriteLine($"Paid {amount} using Credit Card. Card Holder: {cardHolderName}, Card Number: {cardNumber}");
        }
    }

}
