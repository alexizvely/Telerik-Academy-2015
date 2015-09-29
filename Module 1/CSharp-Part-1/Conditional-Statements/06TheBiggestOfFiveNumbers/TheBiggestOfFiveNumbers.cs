//Problem 6. The Biggest of Five Numbers

//Write a program that finds the biggest of five numbers by using only five if statements.
//Examples:

//a	    b	    c	    d	    e	    biggest
//5	    2	    2	    4	    1	    5
//-2	-22	    1	    0	    0	    1
//-2	4	    3	    2	    0	    4
//0	    -2.5	0	    5	    5	    5
//-3	-0.5	-1.1	-2	    -0.1	-0.1

using System;
using System.Globalization;

class TheBiggestOfFiveNumbers
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

        Console.Write("Please input fourth number: ");
        double fourthNum = double.Parse(Console.ReadLine(), invC);

        Console.Write("Please input fifth number: ");
        double fifthNum = double.Parse(Console.ReadLine(), invC);
        
        ///version one of the solution:
        ///double greater = Math.Max(firstNum, Math.Max(secondNum, Math.Max(thirdNum, Math.Max(fourthNum, fifthNum))));
        ///Console.WriteLine("result: {0}", greater);

        ///version two of the solution
        if (firstNum >= secondNum && firstNum >= thirdNum && firstNum >= fourthNum && firstNum >= fifthNum)
        {
            Console.WriteLine("result: " + firstNum);
        }
        else if (firstNum <= secondNum && secondNum >= thirdNum && secondNum >= fourthNum && secondNum >= fifthNum)
        {
            Console.WriteLine("result: " + secondNum);
        }
        else if (thirdNum >= firstNum && secondNum <= thirdNum && thirdNum >= fourthNum && thirdNum >= fifthNum)
        {
            Console.WriteLine("result: " + thirdNum);
        }
        else if (fourthNum >= firstNum && fourthNum >= secondNum && fourthNum >= thirdNum && fourthNum >= fifthNum)
        {
            Console.WriteLine("result: " + fourthNum);
        }
        else if (fifthNum >= firstNum && fifthNum >= secondNum && fifthNum >= thirdNum && fifthNum >= fourthNum)
        {
            Console.WriteLine("result: " + fifthNum);
        }

        ///the following line is to keep the console open. You can press any key to exit the console.
        Console.ReadKey();
    }
}

