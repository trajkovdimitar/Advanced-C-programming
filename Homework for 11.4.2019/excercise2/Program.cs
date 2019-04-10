using System;
using System.Linq;
using System.Collections.Generic;

class LinqExercise5
{
    static void Main(string[] args)
    {
        string str;

        Console.Write("\nDisplay the characters and frequency of character from giving string : ");
        Console.Write("\n----------------------------------------------------------------------------\n");
        Console.Write("Input the string : ");
        str = Console.ReadLine();
        Console.Write("\n");

        IEnumerable<IGrouping<char, char>> FreQ = from x in str
                   group x by x into y
                   select y;

        Console.Write("The frequency of the characters are :\n");
        foreach (IGrouping<char, char> ArrEle in FreQ)
        {
            Console.WriteLine("Character " + ArrEle.Key + ": " + ArrEle.Count() + " times");
        }
        Console.ReadLine();
    }
}