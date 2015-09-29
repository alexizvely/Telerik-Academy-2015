//Problem 10. Find sum in array

//Write a program that finds in given array of integers a sequence of given sum S (if present).
//Example:

//array	                    S	    result
//4, 3, 1, 4, 2, 5, 8	    11	    4, 2, 5


using System;
using System.Linq;

class FindSumInArray
{
    static void Main()
    {
        Console.Write("Enter sum: ");
        int sum = int.Parse(Console.ReadLine());
        Console.Write("Enter integers separated by a comma: ");
        int[] numbers = Console.ReadLine()
            .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

        var startIndex = 0;
        var currentSum = int.MinValue;
        var printed = 0;

        for (int i = 0; i < numbers.Length; i++)
        {

            int count = 0;
            while (currentSum > sum && count < numbers.Length)
            {
                count++;
                currentSum = currentSum - numbers[startIndex];

                if (startIndex != numbers.Length - 1)
                {
                    startIndex = startIndex + 1;
                }
                else
                {
                    continue;
                }
            }

            if (currentSum == sum)
            {
                printed = printed + 1;
                for (int j = startIndex; j < i; j++)
                {
                    Console.Write("{0} ",numbers[j]);
                }
                Console.WriteLine();

                if (startIndex != numbers.Length - 1)
                {
                    startIndex = startIndex + 1;
                }
                else
                {
                    continue;
                }
                currentSum = currentSum - numbers[startIndex - 1];
            }

            if (currentSum < sum)
            {
                currentSum = numbers[i] + currentSum;
            }

        }
        if (printed == 0)
        {
            Console.WriteLine("No subarray found");
        }
        Console.ReadKey();
    }
}

