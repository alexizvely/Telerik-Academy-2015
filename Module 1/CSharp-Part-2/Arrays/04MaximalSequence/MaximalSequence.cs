//Problem 4. Maximal sequence

//Write a program that finds the maximal sequence of equal elements in an array.
//Example:

//input	                            result
//2, 1, 1, 2, 3, 3, 2, 2, 2, 1	    2, 2, 2

using System;
using System.Collections.Generic;
using System.Linq;

class MaximalSequence
{
    static void Main()
    {
        Console.Write("Please enter chars for the array - separated by comma: ");

        string input = Console.ReadLine();
        List<int> inArr = new List<int>();

        string[] numsStr = input.Split(new char[] {',',' '},StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < numsStr.Length; i++)
        {
            inArr.Add(int.Parse(numsStr[i]));
        }

        int count0 = 0;
        int temp0 = 0;
        int char0 = 0;

        for (int i = 0; i < inArr.Count; i++)
        {

            if (i + 1 < inArr.Count && inArr[i] == inArr[i + 1])
            {
                count0 = count0 + 1;

            }
            else
            {
                count0 = 0;
            }
            if (temp0 > count0)
            {
                continue; 
            }
            else
            {
                char0 = inArr[i];
            }

            temp0 = Math.Max(temp0, count0);
        }

        for (int i = 0; i <= temp0; i++)
        {
            Console.Write(char0);
            if (i < temp0)
            {
                Console.Write(", ");
            }
        }

        Console.ReadKey();
    }
}

