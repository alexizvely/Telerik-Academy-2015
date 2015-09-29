//Problem 6. Maximal K sum

//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

using System;
using System.Collections.Generic;
using System.Linq;

class MaximalKSum
{
    static void Main()
    {

        Console.Write("Please enter n (integer number): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Please enter k (integer number): ");
        int k = int.Parse(Console.ReadLine());

        List<int> inArr = new List<int>();

        Console.Write("Please enter chars for the array - separated by comma: ");
        string input = Console.ReadLine();

        string[] numsStr = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < n; i++)
        {
            inArr.Add(int.Parse(numsStr[i]));
        }

        inArr.Sort();

        int sum = 0;

        for (int i = n - 1; i >= n - k; i--)
        {
            sum = sum + inArr[i];
        }

        Console.WriteLine("{0}",sum);

        Console.ReadKey();
    }
}

