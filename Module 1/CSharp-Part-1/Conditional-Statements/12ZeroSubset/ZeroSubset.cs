//Problem 12.* Zero Subset

//We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
//Assume that repeating the same subset several times is not a problem.
//Examples:

//numbers	        result
//3 -2 1 1 8	    -2 + 1 + 1 = 0
//3 1 -7 35 22	    no zero subset
//1 3 -4 -2 -1	    1 + -1 = 0
//                  1 + 3 + -4 = 0
//                  3 + -2 + -1 = 0
//1 1 1 -1 -1	    1 + -1 = 0
//                  1 + 1 + -1 + -1 = 0
//0 0 0 0 0	        0 + 0 + 0 + 0 + 0 = 0
//Hint: you may check for zero each of the 31 subsets with 31 if statements.

using System;
using System.Collections.Generic;

class ZeroSubset
{
    static void Main()
    {

        int s = 0;
        int n = Int32.Parse(Console.ReadLine());
        long[] numbers = new long[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = long.Parse(Console.ReadLine());
        }

        Dictionary<long, int> sums = new Dictionary<long, int>();

        sums.Add(0, 1);
        long currentElement;
        long currentSum;
        for (int i = 0; i < numbers.Length; i++)
        {
            currentElement = numbers[i];
            Dictionary<long, int> copyOfSums = new Dictionary<long, int>(sums);
            foreach (KeyValuePair<long, int> pair in copyOfSums)
            {
                currentSum = currentElement + pair.Key;
                if (!sums.ContainsKey(currentSum))
                {
                    sums.Add(currentSum, pair.Value);
                }
                else
                {
                    sums[currentSum] = sums[currentSum] + pair.Value;
                }
            }
        }
        sums[0]--; //remove the empty subSet

        if (sums.ContainsKey(s))
        {
            Console.WriteLine(sums[s]);
        }
        else
        {
            Console.WriteLine(0);
        }
        ///the following line is to keep the console open. You can press any key to exit the console.
        Console.ReadKey();
    }
}

