using System;
using System.Linq;
using System.Collections.Generic;

class LinqExercise7
{
    static void Main(string[] args)
    {
        int[] nums = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };

        Console.Write("\nDisplay numbers and frequency : ");
        Console.Write("\n-------------------------------------------------------\n");
        Console.Write("The numbers in the array are : \n");
        Console.Write("  5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 \n\n");


        var m = from x in nums
                group x by x into y
                select y;
        Console.Write("Number" + "\t\t" + "Frequency" + "\n");
        Console.Write("-------------------------------------------------------\n");

        foreach (var arrEle in m)
        {
            Console.WriteLine(arrEle.Key + "\t\t" + arrEle.Count());
        }
        Console.WriteLine("-------------------------------------------------------");
        Console.ReadLine();
    }
}