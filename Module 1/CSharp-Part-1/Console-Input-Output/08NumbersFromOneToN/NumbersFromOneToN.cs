//Problem 8. Numbers from 1 to n

//Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.
//Note: You may need to use a for-loop.

//Examples:

//input	    output
//3	        1
//          2
//          3
//5	        1
//          2
//          3
//          4
//          5
//1	        1

using System;

class NumbersFromOneToN
{
    static void Main()
    {

        Console.Write("Please enter integer number (n): ");

        int n = int.Parse(Console.ReadLine());
        int j = -1;
        if (n > 0)
        {
            Console.WriteLine("We will now print all the numbers in the interval [1..n], each on a single line: ");
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }

        else if (n < -1)
        {
            Console.WriteLine("We will now print all the numbers in the interval [1..n], each on a single line: ");
            Console.WriteLine("1\n\r0");
            while (j != (n - 1))
            {

                Console.WriteLine(j);
                j = j - 1;
            } 
        }

        else
        {
            Console.WriteLine("We will now print all the numbers in the interval [1..n], each on a single line: ");
            Console.WriteLine(1);
            if (n == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(0);
                Console.WriteLine(-1);
            }
        }

        ///the following line is to keep the console open. You can press any key to exit the console.
        Console.ReadKey();
    }
}

