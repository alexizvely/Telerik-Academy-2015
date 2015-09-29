//Problem 7. Calculate N! / (K! * (N-K)!)

//In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
//Examples:

//n	k	n! / (k! * (n-k)!)
//3	2	3
//4	2	6
//10	6	210
//52	5	2598960


using System;
using System.Numerics;

class CalculateEquation2
{
    static void Main()
    {

        Console.WriteLine("The following calculates \n\rN! / (K! * (N-K)!)");
        Console.Write("Please enter N (integer number): ");
        double n = double.Parse(Console.ReadLine());

        Console.Write("Please enter k (1 < k < n < 100): ");
        double k = double.Parse(Console.ReadLine());
        double diff = n - k;
        BigInteger nFact = 1;
        BigInteger kFact = 1;
        BigInteger dFact = 1;
        BigInteger result = 0;

        for (int i = 1; i <= n; i++)
        {

            nFact = nFact * i;
            if (diff >= k)
            {
                if (diff < i)
                {
                    continue;
                }

                dFact = dFact * i;
                if (k < i)
                {
                    continue;
                }

                kFact = kFact * i;
            }
            else
            {
                if (k < i)
                {
                    continue;
                }

                kFact = kFact * i;
                if (diff < i)
                {
                    continue;
                }

                dFact = dFact * i;
            }

        }

        result = nFact / (kFact*dFact);
        Console.WriteLine("N! / (K! * (N-K)!) = {0}", result);
        Console.ReadKey();
    }
}

