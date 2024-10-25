namespace DesignPatternsDemo.Prototype
{
    // Prototype: Shape
    public abstract class Shape : ICloneable
    {
        public string Color { get; set; }

        public Shape(string color)
        {
            Color = color;
        }

        // Clone method from ICloneable
        public abstract object Clone();

        public abstract void Draw();
    }
}
