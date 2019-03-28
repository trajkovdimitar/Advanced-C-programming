using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise
{
    class Program
    {
        abstract class Animal
        {
            public abstract bool Feathers { get; set; }
            public virtual string Describe()
            {
                return "This is info for animal: ";
            }
            public abstract string Features();
            public abstract bool HasFeathers();
        }

        class Bird : Animal
        {
            public override bool Feathers { get; set; }
            public virtual string Describe()
            {
                return base.Describe() + "This is a bird.";
            }
            public override string Features()
            {
                return "Can fly!";
            }
            public override bool HasFeathers()
            {
                return true;
            }
        }


        static void Main(string[] args)
        {
            Bird Cavka = new Bird();
            Console.WriteLine(Cavka.Describe());
            Console.WriteLine(Cavka.Features());
            Console.WriteLine(Cavka.HasFeathers());
            Console.WriteLine("-------------------");
            Console.ReadLine();
        }
    }
}
