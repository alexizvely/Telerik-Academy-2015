//Problem 9. Sum of n Numbers

//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.
//Examples:

//numbers	sum
//3	        90
// 20	
// 60	
// 10	
//5	        6.5
// 2	
// -1	
// -0.5	
// 4	
// 2	
//1	        1
// 1	

using System;
using System.Globalization;
using System.Text;

class SumOfNNumbers
{
    static void Main()
    {

        CultureInfo invC = CultureInfo.InvariantCulture;
        Console.Write("Plese enter how many numbers to sum (intiger number): ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter several numbers (each number to be followed with enter): ");

        double sum = 0;

        for (int i = 0; i < n; i++)
        {
            /// the following "Parse(string, invC)" removes the issue with the different delimiter
            sum += double.Parse(Console.ReadLine(), invC);
        }
        Console.WriteLine("------------------------");
        Console.WriteLine("The sum of the {0} numbers is {1}", n, sum);
        Console.WriteLine("------------------------");

        Console.WriteLine();
        Console.Write("Please press enter in case you would like to \ncalculate and print the sum of different n numbers\n");
        Console.WriteLine("------------------------");
        Console.WriteLine();

        /// the following will give you the opportunity to do sum of n numbers multiple times
        ConsoleKeyInfo en;
        do
        {
            en = Console.ReadKey(true);
            if ((en.Key & ConsoleKey.Enter) == 0)
            {
                Console.Write("Plese enter how many numbers to sum (intiger number): ");
                n = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter several numbers (each number to be followed with enter): ");

                sum = 0;

                for (int i = 0; i < n; i++)
                {
                    /// the following "Parse(string, invC)" removes the issue with the different delimiter
                    sum += double.Parse(Console.ReadLine(), invC);
                }

                Console.WriteLine("------------------------");
                Console.WriteLine("The sum of the {0} numbers is {1}", n, sum);
                Console.WriteLine("------------------------");
                Console.WriteLine();
                Console.WriteLine("Please press enter in case you would like to \ncalculate and print the sum of different n numbers\n");
                Console.WriteLine();
            }
        } while ((en.Key & ConsoleKey.Enter) == 0);

    }
}

