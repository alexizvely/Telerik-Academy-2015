//Problem 8. Maximal sum
//Write a program that finds the sequence of maximal sum in given array.
//Example:

//input	                                result
//2, 3, -6, -1, 2, -1, 6, 4, -8, 8	    2, -1, 6, 4
//Can you do it with only one loop (with single scan through the elements of the array)?

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MaximalSum
{

    static int maxSum, maxStartIndex, maxEndIndex = int.MinValue;

    static void Main()
    {

        Console.Write("Enter integers separated by a comma: ");
        int[] numbers = Console.ReadLine()
            .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

        string result;

        result = MaximalSumMethod(numbers);

        Console.Write("Result: ");
        Console.Write(result);
        Console.ReadKey();
    }

    /// <summary>
    /// there is a scheme in the project folder for more information (JPG file)
    /// also, I have listed the resources I have used in More_Resources.txt
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    private static string MaximalSumMethod(int[] numbers)
    {
        int currentMaxSum = int.MinValue;
        int currentStartIndex = 0;

        for (int currentEndIndex = 0; currentEndIndex < numbers.Length; currentEndIndex++)
        {
            currentMaxSum = currentMaxSum + numbers[currentEndIndex];
            if (maxSum < currentMaxSum)
            {
                maxSum = currentMaxSum;
                maxStartIndex = currentStartIndex;
                maxEndIndex = currentEndIndex;
            }

            if (currentMaxSum < 0)
            {
                currentMaxSum = 0;
                currentStartIndex = currentEndIndex + 1;
            }
        }

        StringBuilder result = new StringBuilder(); ;

        for (int i = maxStartIndex; i <= maxEndIndex; i++)
        {
            result.Append(numbers[i]);
            result.Append(" ");
        }
        return result.ToString();
    }
}

