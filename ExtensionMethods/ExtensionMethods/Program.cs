using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;
using System.Collections;
using System;

namespace ExtensionMethods
{
    class Program
    {

        static void Main(string[] args)
        {
            string phrase;
            phrase = "Madam, I`m Adam";
            Console.WriteLine(phrase.IsPalindrom());
            phrase = "Madam, I am Adam";
            Console.WriteLine(phrase.IsPalindrom());
            phrase = "Refer , refer";
            Console.WriteLine(phrase.IsPalindrom());
            Console.WriteLine("-----------------");
            double numeric;
            numeric = 123.321;
            Console.WriteLine(numeric.IsPalindrome());
            Console.ReadLine();            
        }
    }
}
