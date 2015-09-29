//Problem 11. Binary search

//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

using System;
using System.Linq;

class BinarySearch
{

    static void Main()
    {
        Console.Write("Enter numbers separated by a comma: ");
        int[] numbers = Console.ReadLine()
            .Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .OrderBy(x => x)
            .ToArray();


        SelectionSortMethod(numbers);

        Console.Write("Enter a number to search for: ");

        int number = int.Parse(Console.ReadLine());

        int result = BinarySearchMethod(numbers, number);

        if (result != -1)
        {
            Console.WriteLine("Number is found on index: {0}", result);
        }
        else
        {
            Console.WriteLine("Number not found.");
        }

        Console.ReadKey();
    }

    private static int BinarySearchMethod(int[] numbers, int number)
    {
        int middle = numbers.Length / 2;
        int counter = 1;
        int startIndex = 0;
        int endIndex = numbers.Length - 1;
        int tries = numbers.Length / 2 + 1;
        int result = -1;

        do
        {
            if (number < numbers[middle] && middle > 1)
            {
                endIndex = middle;
                middle = endIndex / 2;
            }
            else if (number > numbers[middle] && middle < numbers.Length - 2)
            {
                startIndex = middle;
                middle = (endIndex - startIndex) / 2 + startIndex;
            }
            else if (middle == 1 || middle == numbers.Length - 2)
            {
                if (number == numbers[middle - 1])
                {
                    result = 0;
                }
                else if (number == numbers[middle + 1])
                {
                    result = numbers.Length - 1;
                }
            }
            else
            {
                result = middle;
            }
            counter = counter + 1;
        } while (counter != tries && result == -1);
        return result;
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

