//Problem 2. Compare arrays

//Write a program that reads two integer arrays from the console and compares them element by element.

using System;

class CompareArrays
{
    static void Main()
    {

        Console.Write("Please enter array size (integer number): ");
        int n = int.Parse(Console.ReadLine());

        int[] arrayOne = new int[n];

        Console.Write("Please enter integer numbers for the first array - each followed by enter: ");
        for (int i = 0; i < arrayOne.Length; i++)
        {
            arrayOne[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Please enter array size (integer number): ");
        int m = int.Parse(Console.ReadLine());

        int[] arrayTwo = new int[m];

        for (int i = 0; i < arrayTwo.Length; i++)
        {
            arrayTwo[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Please enter integer numbers for the second array - each followed by enter: ");
        if (n == m)
        {
            for (int i = 0; i < arrayTwo.Length; i++)
            {
                arrayTwo[i] = int.Parse(Console.ReadLine());
            }

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (arrayOne[i] == arrayTwo[i])
                {
                    count++;
                }
            }

            if (count == n)
            {
                Console.WriteLine("The arrays are equal element by element.");
            }
            else
            {
                Console.WriteLine("The arrays are not equal element by element.");
            }
        }
        else
        {
            Console.WriteLine("The arrays are not equal.");
        }

        Console.ReadKey();
    }
}

