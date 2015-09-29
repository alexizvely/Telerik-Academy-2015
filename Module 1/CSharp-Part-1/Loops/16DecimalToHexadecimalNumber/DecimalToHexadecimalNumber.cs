//Problem 16. Decimal to Hexadecimal Number

//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.
//Examples:

//decimal	hexadecimal
//254	FE
//6883	1AE3
//338583669684	4ED528CBB4

using System;

class DecimalToHexadecimalNumber
{
    static void Main()
    {

        Console.WriteLine("The following converts an integer number to its hexadecimal representation.");
        Console.Write("Please enter decimal number: ");
        long n = long.Parse(Console.ReadLine());
        string hex = "";
        long digit = 0;
        string digitToHex = "";

        if (n == 0)
        {
            hex = "0";
        }
        while (n != 0)
        {
            digit = n % 16;

            switch (digit)
            {
                case 0: digitToHex = "0"; break;
                case 1: digitToHex = "1"; break;
                case 2: digitToHex = "2"; break;
                case 3: digitToHex = "3"; break;
                case 4: digitToHex = "4"; break;
                case 5: digitToHex = "5"; break;
                case 6: digitToHex = "6"; break;
                case 7: digitToHex = "7"; break;
                case 8: digitToHex = "8"; break;
                case 9: digitToHex = "9"; break;
                case 10: digitToHex = "A"; break;
                case 11: digitToHex = "B"; break;
                case 12: digitToHex = "C"; break;
                case 13: digitToHex = "D"; break;
                case 14: digitToHex = "E"; break;
                case 15: digitToHex = "F"; break;
            }
            hex = digitToHex + hex;
            n /= 16;
        }
        Console.WriteLine("Hex number = " + hex);

        Console.ReadKey();
    }
}

