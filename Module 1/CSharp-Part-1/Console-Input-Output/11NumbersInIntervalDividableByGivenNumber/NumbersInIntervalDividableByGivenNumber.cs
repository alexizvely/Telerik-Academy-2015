//Problem 11.* Numbers in Interval Dividable by Given Number

//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.
//Examples:

//start	    end	    p	    comments
//17	    25	    2	    20, 25
//5	        30	    6	    5, 10, 15, 20, 25, 30
//3	        33	    6	    5, 10, 15, 20, 25, 30
//3	        4	    0	    -
//99	    120	    5	    100, 105, 110, 115, 120
//107	    196	    18	    110, 115, 120, 125, 130, 135, 140, 145, 150, 155, 160, 165, 170, 175, 180, 185, 190, 195


using System;
using System.Collections;

class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {

        Console.Write("Please enter the first positive integer number: ");
        int firstNum = int.Parse(Console.ReadLine());

        Console.Write("Please enter the second positive integer number: ");
        int secondNum = int.Parse(Console.ReadLine());

        int greater = Math.Max(firstNum, secondNum);
        int smaller = Math.Min(firstNum, secondNum);

        int count = 0;

        /// the following Implements the IList interface using an array whose size is dynamically increased as required.
        /// link to MSDN for more information: https://msdn.microsoft.com/en-us/library/system.collections.arraylist.aspx
        /// Please note that we could just use a simple string instead of array list. However, I wanted to excercise array lists and thus i used them.
        ArrayList comments = new ArrayList();

        for (int i = smaller; i <= greater; i++)
        {
            if (i % 5 == 0)
            {
                comments.Add(i);
                comments.Add(" ");
                ++count;

            }
        }

        Console.WriteLine("-------------------------------------------------------------------------");
        Console.WriteLine("There are {0} numbers from range ({1} to {2}) that when divided by 5 have reminder 0", count, firstNum, secondNum);
        Console.WriteLine("The numbers that when divided by 5 have reminder 0 from range ({0} to {1}) are:", firstNum, secondNum);
        PrintValues(comments);


        ///the following line is to keep the console open. You can press any key to exit the console.
        Console.ReadKey();
    }

    /// the following prints the list
    public static void PrintValues(IEnumerable myList)
    {
        foreach (Object obj in myList)
            Console.Write("{0}", obj);
    }
}

