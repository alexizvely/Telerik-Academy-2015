//Problem 4. Number Comparer

//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.
//Examples:

//a	    b	    greater
//5	    6	    6
//10	5	    10
//0	    0	    0
//-5	-2	    -2
//1.5	1.6	    1.6

using System;
using System.Globalization;

    class NumberComparer
    {
        static void Main()
        {
            CultureInfo invC = CultureInfo.InvariantCulture;

            Console.Write("Please input first number:");
            double firstNum = double.Parse(Console.ReadLine(), invC);
            Console.Write("Please input second number:");
            double secondNum = double.Parse(Console.ReadLine(), invC);

            //Console.WriteLine(firstNum>secondNum ? firstNum:secondNum);
            double greater = Math.Max(firstNum, secondNum);
            double smaller = Math.Min(firstNum, secondNum);
            Console.WriteLine("{0} is greater than {1}", greater, smaller);

            ///the following line is to keep the console open. You can press any key to exit the console.
            Console.ReadKey();
        }
    }

