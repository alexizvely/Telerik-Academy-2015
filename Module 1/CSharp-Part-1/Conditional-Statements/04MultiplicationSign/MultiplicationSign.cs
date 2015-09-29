//Problem 4. Multiplication Sign

//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.
//Examples:

//a	    b	    c	    result
//5	    2	    2	    +
//-2	-2	    1	    +
//-2	4	    3	    -
//0	    -2.5	4	    0
//-1	-0.5	-5.1	-

using System;
using System.Globalization;

class MultiplicationSign
{
    static void Main()
    {

        CultureInfo invC = CultureInfo.InvariantCulture;

        Console.Write("Please enter a: ");
        double a = double.Parse(Console.ReadLine(), invC);

        Console.Write("Please enter b: ");
        double b = double.Parse(Console.ReadLine(), invC);

        Console.Write("Please enter c: ");
        double c = double.Parse(Console.ReadLine(), invC);

        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("Result: 0");
        }
        else if ((a > 0 && b > 0 && c > 0) || (a < 0 && b < 0 && c > 0) || (a > 0 && b < 0 && c < 0) || (a < 0 && b > 0 && c < 0))
        {
            Console.WriteLine("Result: +");

        }
        else if ((a < 0 && b < 0 && c < 0) || (a < 0 && b > 0 && c > 0) || (a > 0 && b > 0 && c < 0) || (a > 0 && b < 0 && c > 0))
        {
            Console.WriteLine("Result: -");
        }

        ///the following line is to keep the console open. You can press any key to exit the console.
        Console.ReadKey();
    }
}

