//Problem 14. Decimal to Binary Number

//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.
//Examples:

//decimal	binary
//0	0
//3	11
//43691	1010101010101011
//236476736	1110000110000101100101000000


using System;

class DecimalToBinaryNumber
{
    static void Main()
    {

        Console.WriteLine("The following converts an integer number to its binary representation.");
        Console.Write("Please enter decimal number: ");
        int n = int.Parse(Console.ReadLine());

        string binary = "";

        if (n == 0)
        {
            binary = "0";
        }
        while (n != 0)
        {
            binary = n % 2 + binary;
            n /= 2;
        }
        Console.WriteLine(binary);

        Console.ReadKey();
    }
}

