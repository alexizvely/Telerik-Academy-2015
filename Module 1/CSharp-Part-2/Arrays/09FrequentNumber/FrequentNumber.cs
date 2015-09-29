//Problem 9. Frequent number

//Write a program that finds the most frequent number in an array.
//Example:

//input	                                    result
//4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	    4 (5 times)

using System;
using System.Linq;

class FrequentNumber
{
    static void Main()
    {

        Console.Write("Enter integers separated by a comma: ");
        int[] numbers = Console.ReadLine()
            .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

        SelectionSortMethod(numbers);

        FrequentNumberMethod(numbers);

        string result;

        result = FrequentNumberMethod(numbers);

        Console.Write("Result: ");
        Console.Write(result);
        Console.ReadKey();
 
    }

    private static string FrequentNumberMethod(int[] numbers)
    {
        var counterFreq = 0;
        var maxCount = 0;
        var valueFreq = 0;

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] == numbers[i - 1])
            {
                counterFreq = counterFreq + 1;
            }
            else
            {
                counterFreq = 0;
            }

            if (maxCount < counterFreq)
            {
                maxCount = counterFreq;
                valueFreq = numbers[i];
            }
        }

        maxCount = maxCount + 1;

        string result;
        return result = valueFreq + " (" + maxCount + " times)";
    }

    private static void SelectionSortMethod(int[] numbers)
    {
        int index = 0;
        int swap;

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            index = i;

            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[index] > numbers[j])
                {
                    index = j;
                }
            }

            swap = numbers[i];
            numbers[i] = numbers[index];
            numbers[index] = swap;
        }
    }
}

