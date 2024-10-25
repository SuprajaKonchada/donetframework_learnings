namespace DesignPatternsDemo.Prototype
{
    // Concrete Prototype: Rectangle
    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(string color, int width, int height) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override object Clone()
        {
            return new Rectangle(this.Color, this.Width, this.Height);
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a {Color} Rectangle of size {Width}x{Height}");
        }
    }
}
