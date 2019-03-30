using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_03.Classes
{
    public class Square : IShape
    {
        public double A { get; private set; }
        public double area;
        public Square(double a)
        {
            A = a;
        }
        public double GetArea()
        {
            if (validator())
            {
                area = A * A;
                Console.WriteLine("The Area of your Square is: {0:F2} m².", area);
            }
            else
            {
                Console.WriteLine("You can`t enter negative numbers or 0 for your area!");
            }
            
            return area;
        }
        double perimeter;
        public double GetPerimeter()
        {
            if (validator())
            {
                perimeter =4 * A;
                Console.WriteLine("The Perimeter of your Square is: {0:F2} m.", perimeter);
            }
            else
            {
                Console.WriteLine("You can`t enter negative numbers or 0 for your perimeter!");
            }
           
            return perimeter;
        }
        bool validation = false;
        public bool validator()
        {
            validation = A <= 0 ? false : true;
            return validation;
        }
    }
}
