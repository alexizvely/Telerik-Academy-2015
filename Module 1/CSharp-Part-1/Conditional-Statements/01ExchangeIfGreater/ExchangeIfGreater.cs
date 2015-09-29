//Problem 1. Exchange If Greater

//Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.
//Examples:

//a	    b	    result
//5	    2	    2 5
//3	    4	    3 4
//5.5	4.5	    4.5 5.5


using System;
using System.Globalization;

class ExchangeIfGreater
{
    static void Main()
    {

        CultureInfo invC = CultureInfo.InvariantCulture;

        Console.Write("Please input first number: ");
        double firstNum = double.Parse(Console.ReadLine(), invC);
        Console.Write("Please input second number: ");
        double secondNum = double.Parse(Console.ReadLine(), invC);

        if (firstNum > secondNum)
            {

                firstNum = firstNum + secondNum;
                secondNum = firstNum - secondNum;
                firstNum = firstNum - secondNum;
                Console.WriteLine("result:\n{0} {1}", firstNum, secondNum);
            }
            else
            {

                Console.WriteLine("result:\n{0} {1}", firstNum, secondNum);
            }

            ///the following line is to keep the console open. You can press any key to exit the console.
            Console.ReadKey();
    }
}

