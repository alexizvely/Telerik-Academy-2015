//Problem 18.* Trailing Zeroes in N!

//Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
//Your program should work well for very big numbers, e.g. n=100000.
//Examples:

//n	trailing zeroes of n!	explaination
//10	2	3628800
//20	4	2432902008176640000
//100000	24999	think why

using System;

class TrailingZeroesInN
{
    static void Main()
    {

        Console.WriteLine("The following calculates with how many zeroes the factorial of a given number n has at its end");
        Console.Write("Please enter N: ");

        int n = int.Parse(Console.ReadLine());
        int count = 0;
        int five = 5;
        int denominator = 0;
        int powerFive = 1;

        while (denominator <= n)
        {
            denominator = (int)Math.Pow(five, powerFive);
            count += n / denominator;
            powerFive++;
        }
        Console.WriteLine(count);

        Console.ReadKey();
    }
}

