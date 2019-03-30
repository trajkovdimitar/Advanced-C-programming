using Lecture_03.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_03
{
    class Program
    {

        static void Main(string[] args)
        {
            #region Text Color
            Console.ForegroundColor = ConsoleColor.Red;
            #endregion
            #region Creating Shapes
            Circle circle = new Circle(2);
            Triangle triangle = new Triangle(3, 4, 5);
            Square square = new Square(2);
            #endregion
            #region Calling Methods
            // Circle
            circle.GetArea();
            circle.GetPerimeter();
            Console.WriteLine("-------------------------------------------\n");
            // Triangle
            triangle.GetArea();
            triangle.GetPerimeter();
            Console.WriteLine("-------------------------------------------\n");
            // Square
            square.GetArea();
            square.GetPerimeter();
            Console.WriteLine("-------------------------------------------\n");
            Console.WriteLine("-------------------------------------------\n");

            ShapeCollection shapes = new ShapeCollection();
            shapes.AddShape(new Circle(2));
            shapes.AddShape(new Square(4));
            shapes.AddShape(new Triangle(3,4,5));
            Console.WriteLine($"There are total of {shapes.Count()} shapes\n");
            Console.WriteLine("The total area of the collection is {0}. \n",shapes.TotalArea());
            Console.WriteLine("The total perimeter of the collection is {0}. \n",shapes.TotalPerimeter());
            #endregion


            Console.WriteLine("\nPress enter to exit...");
            Console.ReadLine();
        }
    }
}
