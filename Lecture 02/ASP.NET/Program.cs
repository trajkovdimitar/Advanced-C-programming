using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET
{
    class Program
    {
        // Static Polymorphism methods (overloading)
        class PrintData
        {
            public void Print(int i)
            {
                Console.WriteLine("Type int: {0}", i);
            }
            public void Print(decimal i)
            {
                Console.WriteLine("Type decimal: {0}", i);
            }
            public void Print(double i)
            {
                Console.WriteLine("Type double: {0}", i);
            }

            public void Print(List<string> st)
            {
                foreach (var item in st)
                {
                    Console.WriteLine("-{0}", item);
                }
            }
            public void Print(Dictionary<int, string> dt)
            {
                foreach (var item in dt)
                {
                    Console.WriteLine("Age:{0}\t Name:{1}", item.Key, item.Value);
                }
            }
            // This methoed covers Lists, Collections, ListArray <- All the generics!
            public void Print<T>(IEnumerable<T> collection) 
            {
                foreach (var item in collection)
                {
                    Console.WriteLine("IEnumerable interface: {0}",item);
                }
            }
        }



        static void Main(string[] args)
        {

            PrintData pd = new PrintData(); // create PrintData type and use its method Print
            pd.Print(100); // This is integer
            pd.Print(100.5M); // Overloading on the same method, just for decimals


           

            List<string> list = new List<string> ()
            {
                "Igor", "Dejan"
            };

            pd.Print(list);

            Dictionary<int, string> dictionary = new Dictionary<int, string>
            {
                { 24, "Dimitar" }, {27, "Dejan" }, {23, "Stefan" }
            };
            pd.Print(dictionary);
                                   
            
            Console.ReadLine();
        }
    }
}
