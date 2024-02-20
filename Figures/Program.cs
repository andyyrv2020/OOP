namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5, 4);
            Circle circle = new Circle(3);

            Console.WriteLine(rectangle.Draw());
            Console.WriteLine("Rectangle Perimeter: " + rectangle.CalculatePerimeter());
            Console.WriteLine("Rectangle Area: " + rectangle.CalculateArea());

            Console.WriteLine(circle.Draw());
            Console.WriteLine("Circle Perimeter: " + circle.CalculatePerimeter());
            Console.WriteLine("Circle Area: " + circle.CalculateArea());
        }
    }
}
