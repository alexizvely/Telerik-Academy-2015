//Problem 14.* Print the ASCII Table

//Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).
//Note: Some characters have a special purpose and will not be displayed as expected. You may skip them or display them differently.

//Note: You may need to use for-loops (learn in Internet how).

using System;
using System.Text;

class PrintTheASCIITable
{
    static void Main()
    {

         // The following wll set console window and buffer size.
        Console.SetBufferSize(200, 600);
        Console.SetWindowSize(200, 50);

        Console.OutputEncoding = Encoding.ASCII;

        Console.WriteLine("ASCII Table\n");
        for (int i = 0; i <= 255; i++)
        {
            char symbol = (char)i;
            Console.WriteLine("ASCII symbol: {0}", symbol);
        }

        ///the following line is to keep the console open. You can press any key to exit the console.
        Console.ReadKey();
    }
}

