//Problem 13. Binary to Decimal Number

//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.
//Examples:

//binary	decimal
//0	0
//11	3
//1010101010101011	43691
//1110000110000101100101000000	236476736

using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.WriteLine("The following converts a binary integer number to its decimal form.");
        Console.Write("Please enter binary number: ");
        string binary = Console.ReadLine();
        int decimalNumber = 0;

        for (int i = 0; i < binary.Length; i++)
        {
            decimalNumber += int.Parse(binary[i].ToString()) * (int)Math.Pow(2, binary.Length - 1 - i);
        }
        Console.WriteLine("Decimal number: " + decimalNumber);

        Console.ReadKey();
    }
}

