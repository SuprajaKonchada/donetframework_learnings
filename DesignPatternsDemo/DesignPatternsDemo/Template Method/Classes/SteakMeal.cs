using DesignPatternsDemo.Template_Method.Abstract_Classes;

namespace DesignPatternsDemo.Template_Method.Classes
{
    public class SteakMeal : MealPreparation
    {
        protected override void PrepareIngredients()
        {
            Console.WriteLine("Preparing steak and seasonings.");
        }

        protected override void Cook()
        {
            Console.WriteLine("Grilling the steak.");
        }
    }

}
