//Problem 6. Calculate N! / K!

//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.
//Examples:

//n	k	n! / k!
//5	2	60
//6	5	6
//8	3	6720

using System;
using System.Linq;

class CalculateNFactToKFact
{
    static void Main()
    {

        Console.WriteLine("The following calculates \n\rn! / k!");
        Console.Write("Please enter n (integer number): ");
        double n = double.Parse(Console.ReadLine());

        Console.Write("Please enter k (1 < k < n < 100): ");
        double k = double.Parse(Console.ReadLine());
        double nFact = 1;
        double kFact = 1;
        double result = 0;

        for (int i = 1; i <= n; i++)
        {
            nFact = nFact * i;

            if (k < i)
            {
                continue; 
            }

            kFact = kFact * i;

        }
        result = nFact / kFact;
        Console.WriteLine("n! / k! = {0}", result);
        Console.ReadKey();
    }
}

