using Exercicio_3.Entities.Enums;
using Exercicio_3.Entities;
using System.Globalization;

namespace Exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            int number_shapes;

            // shape data:
            string shape;
            string color;
 
            double width;
            double height;

            double radius;


            Console.Write("Enter the number of shapes: ");
            number_shapes = int.Parse(Console.ReadLine());

            for(int i = 1; i <= number_shapes; i++)
            {
                Console.WriteLine($"Shape #{i} data:");

                Console.Write("Rectangle or Circle (r/c)? ");
                shape = Console.ReadLine();

                Console.Write("Color (Black/Blue/Red): ");
                color = Console.ReadLine();

                if(shape == "r")
                {
                    Console.Write("Width: ");
                    width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Height: ");
                    height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Rectangle(
                        Enum.Parse<Color>(color),
                        width,
                        height
                        ));
                }
                else
                {
                    Console.Write("Radius: ");
                    radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Circle(
                        Enum.Parse<Color>(color),
                        radius
                        ));
                }
            }

            Console.WriteLine("SHAPE AREAS: ");

            foreach (Shape items in list)
            {
                Console.WriteLine(items.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
