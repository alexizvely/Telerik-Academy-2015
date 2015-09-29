//Problem 4. Unicode Character
//Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the \u00XX syntax, and then print it.
//Hint: first, use the Windows Calculator to find the hexadecimal representation of 42. The output should be *.

using System;

class UnicodeCharacter
{
    static void Main()
    {

        int numberOne = 42;
            ///In the following line is used format specifier X4, where X stands for hexadecimal and 4 stands for the number of digits, which to be shown.
            ///Definition from MSDN: A standard numeric format string takes the form Axx, where:
            ///A is a single alphabetic character called the format specifier.
            ///xx is an optional integer called the precision specifier.
            ///More information on MSDN: http://msdn.microsoft.com/en-us/library/dwhawy9k%28v=vs.110%29.aspx
        string numberOneHex = numberOne.ToString("X4");   
        Console.WriteLine("{0} number is in decimal format. \n{0} in hexadecimal format is {1}",numberOne, numberOneHex);
        var symbol = '\u002A';
        Console.WriteLine("The symbol that has Unicode code 42 (decimal) is {0}", symbol);

            ///the following line is to keep the console open. You can press any key to exit the console.
        Console.ReadKey();
    }
}

