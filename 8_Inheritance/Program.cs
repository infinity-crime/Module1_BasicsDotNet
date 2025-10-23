using _8_Inheritance.Classes;
using _8_Inheritance.Classes.Common;

namespace _8_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            AddClassesToList(shapes);

            CalculationArea(shapes);
        }

        static void AddClassesToList(List<Shape> shapes)
        {
            shapes.Add(new Circle(5.5));
            shapes.Add(new Rectangle(5, 6));
            shapes.Add(new Circle(13.242));
            shapes.Add(new Rectangle(64.3, 2));
            shapes.Add(new Rectangle(2, 2));
            shapes.Add(new Circle(1));
        }

        static void CalculationArea(List<Shape> shapes)
        {
            foreach (Shape shape in shapes)
            {
                if(shape is Circle)
                    Console.WriteLine($"Площадь круга: {shape.GetArea()}");
                else
                    Console.WriteLine($"Площадь прямоугольника: {shape.GetArea()}");
            }

            Console.WriteLine($"Сумма площадей: {shapes.Sum(x => x.GetArea())}");
        }
    }
}
