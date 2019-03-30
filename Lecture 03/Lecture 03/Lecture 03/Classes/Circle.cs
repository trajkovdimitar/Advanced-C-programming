using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_03.Classes
{
    public class Circle : IShape
    {
        public  double area;
        public double Radius { get; private set; }

        public Circle(double x)
        {
            Radius = x;
        }

        public double GetArea()
        {
           
                area = Radius * Radius * Math.PI;
                Console.WriteLine("The Area (A=πr2) of your circle is: {0:F2} m².", area);

                return area;
            
        }

        public double GetPerimeter()
        {
            double area = 2 * Math.PI * Radius;
            Console.WriteLine("The Perimeter (P=2πr) of your circle is: {0:F2} m.", area);
            return area;
        }
    }

}
    

