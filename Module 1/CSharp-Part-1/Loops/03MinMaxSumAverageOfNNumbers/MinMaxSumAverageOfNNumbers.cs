//Problem 3. Min, Max, Sum and Average of N Numbers

//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.
//Example 1:

//input	    output
//3         min = 1
//2         max = 5 
//5         sum = 8 
//1	        avg = 2.67

//Example 2:

//input	    output
//2         min = -1
//-1        max = 4 
//4	        sum = 3 
//          avg = 1.50


using System;
using System.Linq;
using System.Collections.Generic;

class MinMaxSumAverageOfNNumbers
{
    static void Main()
    {
        Console.Write("Please enter a positive integer number: ");

        int n = int.Parse(Console.ReadLine());

        var temp = new List<decimal>();

        decimal add = 0;

        if (n != 1)
        {
            for (int i = 1; i <= n; i++)
            {

                Console.Write("Please enter number {0}: ", i);
                add = decimal.Parse(Console.ReadLine());
                temp.Add(add);
            }
        }

        decimal sum = temp.Sum();
        decimal min = temp.Min();
        decimal max = temp.Max();
        decimal avg = sum / n;

        Console.WriteLine("------------------------", min, max, sum, avg);
        Console.WriteLine("min = {0:F0}\n\rmax = {1:F0}\n\rsum = {2:F0}\n\ravg = {3:F2}", min, max, sum, avg);

        Console.ReadKey();

    }
}

