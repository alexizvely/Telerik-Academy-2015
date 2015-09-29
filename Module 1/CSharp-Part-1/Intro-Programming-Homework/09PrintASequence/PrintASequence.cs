///Problem 9. Print a Sequence
///Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

using System;

class PrintASequence
{
    static void Main()
    {
            /// for each number between 2 and 11 the program will execute the following
        for (int i = 2; i <= 11; i++)
        {
                ///if the remainder after dividing i by two is 0 then the number is even.
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
                ///else the number is not even is displayed with minus sign
            else
            {
                Console.WriteLine(-i);
            }

        }
        
            ///the following line is to keep the console open. You can press any key to exit the console.
        Console.ReadKey();
    }
}

