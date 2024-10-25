using DesignPatternsDemo.Abstract_Factory;
using DesignPatternsDemo.Adapter.Classes;
using DesignPatternsDemo.Builder.Classes;
using DesignPatternsDemo.Composite.Classes;
using DesignPatternsDemo.Composite.Interface;
using DesignPatternsDemo.Decorator.Classes;
using DesignPatternsDemo.Decorator.Interface;
using DesignPatternsDemo.Facade;
using DesignPatternsDemo.Factory.Classes;
using DesignPatternsDemo.Prototype;
using DesignPatternsDemo.Strategy.Classes;
using DesignPatternsDemo.Strategy.Interfaces;
using DesignPatternsDemo.Strategy;
using DesignPatternsDemo.Template_Method.Abstract_Classes;
using DesignPatternsDemo.Template_Method.Classes;
using DesignPatternsDemo.State;

namespace DesignPatternsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Singleton Example: ");
            Parallel.Invoke(
              ()=> PrintStudentDetails(), 
                     ()=> PrintEmployeeDetails()
            );

            Console.WriteLine("\nFactory Example: ");
            new Client().Main();

            Console.WriteLine("\nAbstract Factory Example: ");

            IFurnitureFactory modernFactory = new ModernFurnitureFactory();
            FurnitureClient modernClient = new FurnitureClient(modernFactory);
            Console.WriteLine("Modern Furniture Set:");
            modernClient.DescribeFurniture();

            Console.WriteLine();

            IFurnitureFactory victorianFactory = new VictorianFurnitureFactory();
            FurnitureClient victorianClient = new FurnitureClient(victorianFactory);
            Console.WriteLine("Victorian Furniture Set:");
            victorianClient.DescribeFurniture();

            Console.WriteLine();

            IFurnitureFactory artDecoFactory = new ArtDecoFurnitureFactory();
            FurnitureClient artDecoClient = new FurnitureClient(artDecoFactory);
            Console.WriteLine("ArtDeco Furniture Set:");
            artDecoClient.DescribeFurniture();

            Console.WriteLine("\nBuilder Example: ");
            // Create the builder
            HouseBuilder builder = new SimpleHouseBuilder();

            // Create the director
            HouseDirector director = new HouseDirector(builder);

            // Construct the house
            director.ConstructHouse();

            // Get and display the house details
            House house = director.GetConstructedHouse();
            house.ShowDetails();

            Console.WriteLine("\nPrototype Example: ");


            // Create original Circle
            Circle circle1 = new Circle("Red", 10);
            circle1.Draw();

            // Clone the Circle
            Circle circle2 = (Circle)circle1.Clone();
            circle2.Color = "Blue"; // Changing the color of the clone
            circle2.Draw();

            // Create original Rectangle
            Rectangle rectangle1 = new Rectangle("Green", 15, 25);
            rectangle1.Draw();

            // Clone the Rectangle
            Rectangle rectangle2 = (Rectangle)rectangle1.Clone();
            rectangle2.Color = "Yellow"; // Changing the color of the clone
            rectangle2.Draw();

            Console.WriteLine("\nAdapter Example: ");
            AudioPlayer audioPlayer = new AudioPlayer();

            audioPlayer.Play("mp3", "song.mp3");
            audioPlayer.Play("mp4", "video.mp4");
            audioPlayer.Play("vlc", "movie.vlc");
            audioPlayer.Play("avi", "movie.avi");

            Console.WriteLine("\nDecorator Example: ");
            // Create a basic car
            ICar myCar = new BasicCar();
            Console.WriteLine($"{myCar.GetDescription()} costs ${myCar.GetCost()}");

            // Add a sunroof to the car
            myCar = new Sunroof(myCar);
            Console.WriteLine($"{myCar.GetDescription()} costs ${myCar.GetCost()}");

            // Add a sports package to the car
            myCar = new SportsPackage(myCar);
            Console.WriteLine($"{myCar.GetDescription()} costs ${myCar.GetCost()}");

            // Add both Sunroof and Sports Package to the car
            ICar fullyLoadedCar = new SportsPackage(new Sunroof(new BasicCar()));
            Console.WriteLine($"{fullyLoadedCar.GetDescription()} costs ${fullyLoadedCar.GetCost()}");

            Console.WriteLine("\nFacade Example: ");
            // Facade instance
            CarPurchaseFacade carPurchaseFacade = new CarPurchaseFacade();

            // Buying a car using the facade
            carPurchaseFacade.BuyCar("Supraja Konchada", "Tesla Model S");

            Console.WriteLine("\nComposite Example: ");
            // Create employees
            IEmployee emp1 = new Employee("Sanjay Kumar", "Software Engineer");
            IEmployee emp2 = new Employee("Sujatha", "QA Engineer");
            IEmployee emp3 = new Employee("Amisha", "DevOps Engineer");

            // Create managers
            Manager manager1 = new Manager("Rameshwara", "Development Manager");
            Manager manager2 = new Manager("Vamsi", "QA Manager");

            // Assign employees to managers
            manager1.AddSubordinate(emp1); // Development Manager manages Software Engineer
            manager1.AddSubordinate(emp3); // Development Manager manages DevOps Engineer
            manager2.AddSubordinate(emp2); // QA Manager manages QA Engineer

            // Create a higher-level manager
            Manager director1 = new Manager("Supraja", "Engineering Director");

            // Director manages both managers
            director1.AddSubordinate(manager1); // Director manages Development Manager
            director1.AddSubordinate(manager2); // Director manages QA Manager

            // Get details of the organization structure
            Console.WriteLine(director1.GetDetails());

            Console.WriteLine("\nTemplate Method Example: ");
            // Prepare Pasta
            MealPreparation pastaMeal = new PastaMeal();
            Console.WriteLine("Preparing Pasta Meal:");
            pastaMeal.PrepareMeal();

            Console.WriteLine();

            // Prepare Steak
            MealPreparation steakMeal = new SteakMeal();
            Console.WriteLine("Preparing Steak Meal:");
            steakMeal.PrepareMeal();

            Console.WriteLine("\nStratery Example: ");
            PaymentProcessor paymentProcessor = new PaymentProcessor();

            // Use Credit Card payment strategy
            IPaymentStrategy creditCardPayment = new CreditCardPayment("9876543210", "Supraja Konchada");
            paymentProcessor.SetPaymentMethod(creditCardPayment);
            paymentProcessor.Pay(100.50);

            // Switch to PayPal payment strategy
            IPaymentStrategy payPalPayment = new PayPalPayment("suprajakonchada@gmail.com");
            paymentProcessor.SetPaymentMethod(payPalPayment);
            paymentProcessor.Pay(250.75);

            Console.WriteLine("\nState Example: ");
            Document document = new Document();

            Console.WriteLine($"Initial State: {document.GetCurrentState()}");

            // Try publishing the document (from Draft to Moderation)
            document.Publish();
            Console.WriteLine($"Current State: {document.GetCurrentState()}");

            // Try rejecting the document (from Moderation to Draft)
            document.Reject();
            Console.WriteLine($"Current State: {document.GetCurrentState()}");

            // Try publishing again (from Draft to Moderation)
            document.Publish();
            Console.WriteLine($"Current State: {document.GetCurrentState()}");

            // Publish the document (from Moderation to Published)
            document.Publish();
            Console.WriteLine($"Current State: {document.GetCurrentState()}");

            // Try rejecting the published document (Invalid operation)
            document.Reject();
            Console.WriteLine($"Current State: {document.GetCurrentState()}");
            Console.ReadLine();
        }

        private static void PrintEmployeeDetails()
        {
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
        }

        private static void PrintStudentDetails()
        {
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PrintDetails("From Employee");
        }
    }
}