//Problem 3. Compare char arrays

//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class CompareCharArrays
{
    static void Main()
    {

        Console.Write("Please enter array size (integer number): ");
        int n = int.Parse(Console.ReadLine());

        char[] arrayOne = new char[n];

        Console.Write("Please enter chars for the first array - each followed by enter: ");
        for (int i = 0; i < arrayOne.Length; i++)
        {
            arrayOne[i] = Console.ReadLine()[0];
        }

        Console.Write("Please enter array size (integer number): ");
        int m = int.Parse(Console.ReadLine());

        char[] arrayTwo = new char[m];

        Console.Write("Please enter chars for the second array - each followed by enter: ");
        for (int i = 0; i < arrayTwo.Length; i++)
        {
            arrayTwo[i] = Console.ReadLine()[0];
        }

        char checkOne = ' ';
        char checkTwo = ' ';
        int count = 0;

        for (int i = 0; i < n; i++)
        {
            checkOne = arrayOne[i];

            checkTwo = arrayTwo[i];

            if (checkOne == checkTwo)
            {
                count = count + 1;
                continue;
            }
            else if (checkOne > checkTwo)
            {
                Console.WriteLine("Array One is > lexicographically than Array Two.");
            }
            else
            {
                Console.WriteLine("Array Two is > lexicographically than Array One.");
            }

        }
        if (n == m && count == n)
        {
            Console.WriteLine("The two arrays are equal.");
        }

        Console.ReadKey();
    }
}

