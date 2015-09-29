//Problem 7. Selection sort

//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, 
//find the smallest from the rest, move it at the second position, etc.

using System;
using System.Linq;


namespace _07SelectionSort
{
    class SelectionSort
    {
        static void Main()
        {
            Console.Write("Enter integers separated by a comma: ");
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            SelectionSortMethod(numbers);

            Console.Write("After Sort: ");
            Console.Write(String.Join(",", numbers));
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
}


