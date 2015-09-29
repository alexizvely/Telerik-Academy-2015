//Problem 1. Sum of 3 Numbers

//Write a program that reads 3 real numbers from the console and prints their sum.
//Examples:

//a	    b	    c	    sum
//3	    4	    11	    18
//-2	0	    3	    1
//5.5	4.5	    20.1	30.1

using System;
using System.Globalization;

class SumOfThreeNumbers
{
    static void Main()
    {
        CultureInfo invC = CultureInfo.InvariantCulture;

        Console.WriteLine("Enter three numbers (each number to be followed with enter): ");
        double sum = 0;

        for (int i = 0; i < 3; i++)
        {
            /// the following "Parse(string, invC)" removes the issue with the different delimiter
            sum += double.Parse(Console.ReadLine(), invC);
        }

        Console.WriteLine("The sum of the three numbers is {0}", sum);

        ///the following line is to keep the console open. You can press any key to exit the console.
        Console.ReadKey();
    }
}

