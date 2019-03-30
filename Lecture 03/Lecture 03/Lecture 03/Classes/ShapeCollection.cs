using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_03.Classes
{
   public class ShapeCollection
    {
        private List<IShape> shapes = new List<IShape>();

        public void AddShape(IShape shape)
        {
            shapes.Add(shape);
        }

        public  double TotalPerimeter()
        {
            double sum = 0;
            foreach (var item in shapes)
            {
              sum+= item.GetPerimeter();               
            }
            return sum;
        }

        public double TotalArea()
        {
            double sum = 0;
            for (int i = 0; i < shapes.Count; i++)
            {
                IShape item = shapes[i];
                sum += item.GetArea();
            }
            return sum;
        }
        int counter=0;
        public int Count()
        {
            foreach (var item in shapes)
            {
                counter++;
            }
            return counter;
        }
        
    }
}
