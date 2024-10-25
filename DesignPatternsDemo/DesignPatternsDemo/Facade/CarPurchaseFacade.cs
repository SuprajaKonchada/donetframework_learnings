using DesignPatternsDemo.Facade.Classes;

namespace DesignPatternsDemo.Facade
{
    public class CarPurchaseFacade
    {
        private LoanSystem _loanSystem;
        private CreditSystem _creditSystem;
        private InsuranceSystem _insuranceSystem;
        private RegistrationSystem _registrationSystem;

        public CarPurchaseFacade()
        {
            _loanSystem = new LoanSystem();
            _creditSystem = new CreditSystem();
            _insuranceSystem = new InsuranceSystem();
            _registrationSystem = new RegistrationSystem();
        }

        public void BuyCar(string customerName, string carModel)
        {
            Console.WriteLine($"Customer {customerName} is buying {carModel}.");

            // Call subsystems via facade
            if (_loanSystem.CheckLoanEligibility(customerName) &&
                _creditSystem.CheckCreditScore(customerName) &&
                _insuranceSystem.ProvideInsurance(customerName) &&
                _registrationSystem.RegisterVehicle(customerName, carModel))
            {
                Console.WriteLine($"{customerName} successfully bought {carModel}.");
            }
            else
            {
                Console.WriteLine($"{customerName} could not complete the purchase of {carModel}.");
            }
        }
    }

}
