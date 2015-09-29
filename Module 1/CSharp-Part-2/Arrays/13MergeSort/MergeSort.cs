//Problem 13.* Merge sort

//Write a program that sorts an array of integers using the Merge sort algorithm.

using System;
using System.Linq;

class MergeSort
{
    static void Main()
    {
        Console.Write("Enter numbers separated by a comma: ");
        int[] numbers = Console.ReadLine()
            .Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .OrderBy(x => x)
            .ToArray();

        Console.ReadKey();
    }

}

