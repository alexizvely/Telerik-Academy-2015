//Problem 5. Maximal increasing sequence

//Write a program that finds the maximal increasing sequence in an array.
//Example:

//input	                    result
//3, 2, 3, 4, 2, 2, 4	    2, 3, 4


using System;
using System.Collections.Generic;
using System.Linq;

class MaximalIncreasingSequence
{
    static void Main()
    {

        Console.Write("Please enter chars for the array - separated by comma: ");

        string input = Console.ReadLine();
        List<int> inArr = new List<int>();

        string[] numsStr = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < numsStr.Length; i++)
        {
            inArr.Add(int.Parse(numsStr[i]));
        }

        int count0 = 0;
        int temp0 = 0;
        int start = 0;

        for (int i = 0; i < inArr.Count; i++)
        {
            if (i + 1 < inArr.Count && inArr[i] < inArr[i + 1])
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
                start = i;
            }

            temp0 = Math.Max(temp0, count0);
        }

        for (int i = start - 1; i < start + temp0; i++)
        {
            Console.Write("{0}",inArr[i]);
            if (i < start + temp0 - 1)
            {
                Console.Write(", ");
            }
        }

        Console.ReadKey();
    }
}

