//Problem 7. Sort 3 Numbers with Nested Ifs

//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.
//Note: Don’t use arrays and the built-in sorting functionality.

//Examples:

//a	    b	    c	    result
//5	    1	    2	    5 2 1
//-2	-2	    1	    1 -2 -2
//-2	4	    3	    4 3 -2
//0	    -2.5	5	    5 0 -2.5
//-1.1	-0.5	-0.1	-0.1 -0.5 -1.1
//10	20	    30	    30 20 10
//1	    1	    1	    1 1 1


/// built-in sorting functionality: https://msdn.microsoft.com/en-us/library/b0zbh7b6%28v=vs.110%29.aspx

using System;
using System.Globalization;

class SortThreeNumbersWithNestedIfs
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

        if (firstNum == secondNum && secondNum == thirdNum)
            {
                Console.WriteLine("{0} {1} {2}", firstNum, secondNum, thirdNum);
            }
            else
            {
                if (firstNum > secondNum && firstNum > thirdNum && secondNum > thirdNum)
                {
                    Console.WriteLine("sorting result: {0} {1} {2}", firstNum, secondNum, thirdNum);
                }
                else if (firstNum > secondNum && firstNum > thirdNum && secondNum < thirdNum)
                {
                    Console.WriteLine("sorting result: {0} {1} {2}", firstNum, thirdNum, secondNum);
                }
                else if (secondNum > firstNum && firstNum > thirdNum && secondNum > thirdNum)
                {
                    Console.WriteLine("sorting result: {0} {1} {2}", secondNum, firstNum, thirdNum);
                }
                else if (secondNum > thirdNum && thirdNum > firstNum && secondNum > thirdNum)
                {
                    Console.WriteLine("sorting result: {0} {1} {2}", secondNum, thirdNum, firstNum);
                }
                else if (thirdNum > firstNum && firstNum > secondNum && thirdNum > secondNum)
                {
                    Console.WriteLine("sorting result: {0} {1} {2}", thirdNum, firstNum, secondNum);
                }
                else
                {
                    Console.WriteLine("sorting result: {0} {1} {2}", thirdNum, secondNum, firstNum);
                }
            }

        ///the following line is to keep the console open. You can press any key to exit the console.
        Console.ReadKey();
    }
}

