using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Program
    {
        class Shape
        {
            protected double A { get; set; } = 1;
            protected double B { get; set; } = 1;
            protected double R { get; set; } = 1;
            public Shape() { }
            public Shape(double x, double y)
            {
                A = x; B = y;
            }
            public Shape(double radius)
            {
                R = radius;
            }
            public virtual double Area()
            {
                Console.WriteLine("Parent Class Area\n----------");

                return A * B;
            }
        }
        class Rectangle : Shape
        {
            double a { get; set; }
            double b { get; set; }
            public Rectangle(double x, double y) : base(x, y)
            {
                a = x; b = y;
            }
            public override double Area()
            {
                Console.WriteLine("Rectangle Class Area\n------");
                return  a * b;
            }

        }
        class Triangle : Shape
        {
            double a { get; set; }
            double b { get; set; }
            public Triangle(double x, double y, double r) : base(x, y)
            {
                a = x; b = y;
            }
            public override double Area()
            {
                Console.WriteLine("Triangle Class Area\n--------");
                return a * b/2;
            }

        }
        class Circle : Shape
        {
            double a { get; set; }
            double b { get; set; }
            public Circle(double r) : base(r)
            {
            R=r;
            }
            public override double Area()
            {
                Console.WriteLine("Circle Class Area\n--------");
                return Math.PI*Math.Pow(R,2);
            }

        }

        class Caller
        {
            public void Print(Shape s)
            {
                Console.WriteLine("Area: {0}", s.Area());
            }
        }

        static void Main(string[] args)
        {
            Shape s1 = new Shape();
            Shape s2 = new Shape(1, 2);
            Console.WriteLine(s2.Area());
            Rectangle s3 = new Rectangle(3,5);
            Circle s4 = new Circle(5);
            Console.WriteLine("Circle Area: " + s4.Area());
            Caller caller = new Caller();
            caller.Print(s2);
            Console.ReadLine();
        }
    }
}

