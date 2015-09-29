using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

/// You are given a text and a number (M)
/// This text can contain digits, Latin letters (both capital and letter case) and any other symbols, except for '@'
/// •	If the current character is '@', stop the program and print the RESULT
//•	If the current character is a digit (0-9), then multiply the RESULT by this digit
//•	If the current character is a letter, add its number from the Latin alphabet to RESULT. 'A' is with number 0
//•	If the current character is a symbol, that is different from the ones above, create module of the RESULT by the provided number (M)

class TextToNumber
{
    static void Main()
    {
        ///•	M will always be between 2000 and 10 000
        //•	The length of the text will always be less than 100 000


        long m = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();

        int count = input.Length - 1;

        char checker = input[0];
        bool isDigit = false;
        long sym = 0;
        BigInteger result = 0;
        bool isStop = input[0] == '@';



            for (int i = 0; i < count; i++)
            {
                isStop = input[i] == '@';
                if (isStop)
                {
                    break;
                }
                checker = input[i];
                isDigit = char.IsDigit(checker);

                if (isDigit)
                {
                    switch (checker)
                    {
                        case '0': result = result * 0; break;
                        case '1': result = result * 1; break;
                        case '2': result = result * 2; break;
                        case '3': result = result * 3; break;
                        case '4': result = result * 4; break;
                        case '5': result = result * 5; break;
                        case '6': result = result * 6; break;
                        case '7': result = result * 7; break;
                        case '8': result = result * 8; break;
                        case '9': result = result * 9; break;
                        default: break;
                    }
                }
                else if (char.ToUpper(checker) <= 90 && char.ToUpper(checker) >= 65)
                {
                    sym = char.ToUpper(checker) - 'A';
                    result = result + sym;
                }
                else
                {
                    result = result % m;
                }
            }

        Console.WriteLine(result);

    }
}

