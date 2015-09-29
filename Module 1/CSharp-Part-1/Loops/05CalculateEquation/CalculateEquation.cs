//Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
//Use only one loop. Print the result with 5 digits after the decimal point.
//Examples:

//n	x	S
//3	2	2.75000
//4	3	2.07407
//5	-4	0.75781

using System;

class CalculateEquation
{
    static void Main()
    {
        Console.WriteLine("The following calculates \n\r1 + 1!/X + 2!/X^2 + … + N!/X^N");
        Console.Write("Please enter N (integer number): ");
        double n = double.Parse(Console.ReadLine());

        Console.Write("Please enter X (integer number): ");
        double x = double.Parse(Console.ReadLine());
        double nFact = 1;
        double xCalc = x;
        double result = 1 + 1/x;

        for (int i = 2; i <= n; i++)
        {
            nFact = nFact * i;
            xCalc = Math.Pow(x, i);
            result = result + nFact/xCalc;

        }

        Console.WriteLine("1 + 1!/X + 2!/X^2 + … + N!/X^N = {0:N5}", result);
        Console.ReadKey();
    }
}

