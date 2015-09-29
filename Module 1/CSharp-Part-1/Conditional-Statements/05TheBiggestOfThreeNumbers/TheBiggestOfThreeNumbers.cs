//Problem 5. The Biggest of 3 Numbers

//Write a program that finds the biggest of three numbers.
//Examples:

//a	    b	    c	    biggest
//5	    2	    2	    5
//-2	-2	    1	    1
//-2	4	    3	    4
//0	    -2.5	5	    5
//-0.1	-0.5	-1.1	-0.1

using System;
using System.Globalization;

class TheBiggestOfThreeNumbers
{
    static void Main()
    {

        CultureInfo invC = CultureInfo.InvariantCulture;

        Console.Write("Please input first number: ");
        double firstNum = double.Parse(Console.ReadLine(), invC);

        Console.Write("Please input second number: ");
        double secondNum = double.Parse(Console.ReadLine(), invC);

        Console.Write("Please input third number: ");
        double thirdNum = double.Parse(Console.ReadLine(), invC);

        /// source: http://stackoverflow.com/questions/6800838/in-c-sharp-is-there-a-method-to-find-the-max-of-3-numbers
        double greater = Math.Max(firstNum, Math.Max(secondNum, thirdNum));

        Console.WriteLine("result: {0}", greater);

        ///the following line is to keep the console open. You can press any key to exit the console.
        Console.ReadKey();
    }
}

