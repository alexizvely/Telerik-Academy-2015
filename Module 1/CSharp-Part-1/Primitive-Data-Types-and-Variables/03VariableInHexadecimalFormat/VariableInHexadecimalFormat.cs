//Problem 3. Variable in Hexadecimal Format
//Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##).
//Use Windows Calculator to find its hexadecimal representation.
//Print the variable and ensure that the result is 254.

using System;

class VariableInHexadecimalFormat
{
    static void Main()
    {

        int numberOne = 254;
        int numberOneHex = 0xFE;
            ///In the following line is used format specifier X4, where X stands for hexadecimal and 4 stands for the number of digits, which to be shown.
            ///Definition from MSDN: A standard numeric format string takes the form Axx, where:
            ///A is a single alphabetic character called the format specifier.
            ///xx is an optional integer called the precision specifier.
            ///More information on MSDN: http://msdn.microsoft.com/en-us/library/dwhawy9k%28v=vs.110%29.aspx

        Console.WriteLine("{0} number is in decimal format. \n{0} in hexadecimal format is {1} \n\nCheck: is {0} value in hexadecimal format {1} : {2}", numberOne, numberOne.ToString("X4"), ((numberOne==numberOneHex) ? true : false));

            ///the following line is to keep the console open. You can press any key to exit the console.
        Console.ReadKey();
    }
}

