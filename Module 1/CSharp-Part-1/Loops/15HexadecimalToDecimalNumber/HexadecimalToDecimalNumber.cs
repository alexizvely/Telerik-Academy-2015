//Problem 15. Hexadecimal to Decimal Number

//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.
//Examples:

//hexadecimal	decimal
//FE	254
//1AE3	6883
//4ED528CBB4	338583669684

using System;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        Console.WriteLine("The following converts a hexadecimal integer number to its decimal form.");
        Console.Write("Please enter HEX: ");
        string hex = Console.ReadLine();

        int count = 0;
        char digit = hex[count];
        decimal decNumber = 0;
        int num = 0;
        while (true)
        {
            switch (digit)
            {
                case '0': num = 0; break;
                case '1': num = 1; break;
                case '2': num = 2; break;
                case '3': num = 3; break;
                case '4': num = 4; break;
                case '5': num = 5; break;
                case '6': num = 6; break;
                case '7': num = 7; break;
                case '8': num = 8; break;
                case '9': num = 9; break;
                case 'A': num = 10; break;
                case 'B': num = 11; break;
                case 'C': num = 12; break;
                case 'D': num = 13; break;
                case 'E': num = 14; break;
                case 'F': num = 15; break;
            }

            decNumber += num * (decimal)Math.Pow(16, hex.Length - 1 - count);
            count++;
            if (count == hex.Length)
            {
                break;
            }
            digit = hex[count];
        }
        Console.WriteLine("Decimal number = " + decNumber);

        Console.ReadKey();
    }
}

