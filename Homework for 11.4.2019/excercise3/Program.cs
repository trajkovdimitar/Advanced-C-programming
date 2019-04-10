using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  

class LinqExercise9  
    {  
        static void Main(string[] args)  
        {
            Console.Write("\nAccept the members of a list through the keyboard and display the members more than a specific value : ");
        Console.WriteLine("\nEnter 5 integers from keyboard : ");
            Console.Write("----------------------------------------------------------------------------\n");
            List<int> templist = new List<int>();
            int numVal = Int32.Parse(Console.ReadLine());
            templist.Add(numVal);
            numVal = Int32.Parse(Console.ReadLine());
            templist.Add(numVal);
            numVal = Int32.Parse(Console.ReadLine());
            templist.Add(numVal);
            numVal = Int32.Parse(Console.ReadLine());
            templist.Add(numVal);
            numVal = Int32.Parse(Console.ReadLine());
            templist.Add(numVal);

        Console.WriteLine("\nInput the value above you want to display the members of the List : ");
            int valGr = Int32.Parse(Console.ReadLine());

        Console.Write($"\nCreate a list of numbers and display the numbers greater than {valGr} : "); 
            Console.Write("\n----------------------------------------------------------------------------\n");				
            Console.WriteLine("\nThe members of the list are : ");            
            foreach (var lstnum in templist)  
            {  
                Console.Write(lstnum+" ");  
            }  
            List<int> FilterList = templist.FindAll(x => x > valGr ? true : false);  
            Console.WriteLine($"\n\nThe numbers greater than {valGr} are : ");
            foreach (var num in FilterList)  
            {  
                Console.WriteLine(num);  
            }  
            Console.ReadLine();  
        }  
    }