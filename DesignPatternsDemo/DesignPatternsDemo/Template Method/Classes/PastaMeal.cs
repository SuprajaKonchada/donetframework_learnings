using DesignPatternsDemo.Template_Method.Abstract_Classes;

namespace DesignPatternsDemo.Template_Method.Classes
{
    public class PastaMeal : MealPreparation
    {
        protected override void PrepareIngredients()
        {
            Console.WriteLine("Preparing pasta and sauce ingredients.");
        }

        protected override void Cook()
        {
            Console.WriteLine("Cooking pasta and making sauce.");
        }
    }

}
