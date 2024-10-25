namespace DesignPatternsDemo.Prototype
{
    // Concrete Prototype: Circle
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public Circle(string color, int radius) : base(color)
        {
            Radius = radius;
        }

        public override object Clone()
        {
            return new Circle(this.Color, this.Radius);
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a {Color} Circle with radius {Radius}");
        }
    }
}
