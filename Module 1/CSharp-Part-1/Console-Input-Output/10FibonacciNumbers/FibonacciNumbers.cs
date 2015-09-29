//Problem 10. Fibonacci Numbers

//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
//Note: You may need to learn how to use loops.

//Examples:

//n	    comments
//1	    0
//3	    0 1 1
//10	0 1 1 2 3 5 8 13 21 34

using System;

class FibonacciNumbers
{
    static void Main()
    {

        int count = 0;

        do
        {

            Console.Write("Please enter count: ");

            count = int.Parse(Console.ReadLine());

            if (count < 1)
            {

                Console.WriteLine("No number to show. Please enter number bigger than 0.");
            }

            else
            {

                if (count > 2)
                {
                    Int32[] fibonacciNum = new Int32[Math.Max(count, 3)];

                    fibonacciNum[0] = 0;
                    fibonacciNum[1] = 1;
                    fibonacciNum[2] = 1;


                    for (int i = 3; i < fibonacciNum.Length; i++)
                    {
                        fibonacciNum[i] = fibonacciNum[i - 1] + fibonacciNum[i - 2];
                    }

                    Console.WriteLine("Fibonacci sequence of {0}:", count);
                    //Join(String, String[]) --->> Concatenates all the elements of a string array, using the specified separator between each element.
                    //Link to MSDN for more information: https://msdn.microsoft.com/en-us/library/57a79xd0(v=vs.110).aspx 
                    Console.WriteLine(string.Join(" ", fibonacciNum));
                }

                else if (count == 2)
                {
                    
                    Console.WriteLine("Fibonacci sequence of {0}:", count);
                    Console.WriteLine("0 1");
                }

                else
                {
                    
                    Console.WriteLine("Fibonacci sequence of {0}:", count);
                    Console.WriteLine("0");   
                }

            }

        } while (count<1);

        ///the following line is to keep the console open. You can press any key to exit the console.
        Console.ReadKey();
    }
}

