namespace DesignPatternsDemo.Template_Method.Abstract_Classes
{
    public abstract class MealPreparation
    {
        // Template method
        public void PrepareMeal()
        {
            PrepareIngredients();
            Cook();
            Serve();
        }

        // Common method
        private void Serve()
        {
            Console.WriteLine("Serving the meal.");
        }

        // Abstract methods for subclasses to implement
        protected abstract void PrepareIngredients();
        protected abstract void Cook();
    }

}
