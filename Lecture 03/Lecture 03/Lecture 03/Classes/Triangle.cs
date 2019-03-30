using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_03.Classes
{
    public class Triangle : IShape
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double area;
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public double GetArea()
        {
                    if (IsValidTriangle(A,B,C))
                    {
                        double hf = GetPerimeter() / 2;
                        area = Math.Sqrt(hf * (hf - A) * (hf - B) * (hf - C));
                        Console.WriteLine("The Area of your triangle is: {0:F2} m².", area);
                    }
                    else
                    {
                        Console.WriteLine("Your triangle is {0} and you can`t calculate area.",validator);
                    }
            return area;
        }
        double result;
        public double GetPerimeter()
        {
            
            if (IsValidTriangle(A,B,C))
            {
                result += A + B + C;
                Console.WriteLine("The perimeter of your triangle is : {0:F2} m.", result);
            }
            else
            {
                Console.WriteLine("Your triangle is {0} and you can`t calculate perimeter.", validator);
            }
            return result;
        }
        bool validator = false;
        public bool IsValidTriangle(double a, double b,double c)
        {
            validator = a +b<c||a+c<b||c+b<a ? false : true;
            return validator;

        }
    }
}
