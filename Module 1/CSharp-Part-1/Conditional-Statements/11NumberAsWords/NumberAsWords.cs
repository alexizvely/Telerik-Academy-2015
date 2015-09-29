//Problem 11.* Number as Words

//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.
//Examples:

//numbers	number as words
//0	        Zero
//9	        Nine
//10	    Ten
//12	    Twelve
//19	    Nineteen
//25	    Twenty five
//98	    Ninety eight
//98	    Ninety eight
//273	    Two hundred and seventy three
//400	    Four hundred
//501	    Five hundred and one
//617	    Six hundred and seventeen
//711	    Seven hundred and eleven
//999	    Nine hundred and ninety nine

namespace _11NumberAsWords
{
    using System;
    using System.Collections;

    class NumberAsWords
    {
        static void Main()
        {

            Console.WriteLine("Please enter an integer number in range [0...999]: ");

            /// link to MSDN for more info: https://msdn.microsoft.com/en-us/library/system.collections.arraylist.aspx
            string input = Console.ReadLine();
            int len = input.Length;
            int digit;

            if (len == 0)
            {
                input = input + "   ";
            }
            else if (len == 1)
            {
                input = input + "  ";
            }
            else if (len == 2)
            {
                input = input + " ";
            }

            char[] inputAr = input.ToCharArray();

            if (((len > 3) || (len == 0) || (input.Contains(".")) || !(Char.IsDigit(inputAr[0]))) || (len > 1 && !(Char.IsDigit(inputAr[1]))) || (len > 2 && !(Char.IsDigit(inputAr[2]))))
            {
                Console.WriteLine("Error. You haven't entered integer number in range [0...999].");
            }
            else if (len == 1)
            {
                digit = (int)inputAr[0] - 48;
                Console.WriteLine(DigitAsWord(digit));

            }
            else if (len == 2 && (((digit = (int)inputAr[0] - 48) == 1) || (digit = (int)inputAr[1] - 48) == 0))
            {

                digit = ((int)inputAr[0] - 48) * 10 + (int)inputAr[1] - 48;
                Console.WriteLine(DigitAsWord(digit));
            }
            else if (len == 2 && !(((digit = (int)inputAr[0] - 48) == 1) || (digit = (int)inputAr[1] - 48) == 0))
            {

                digit = ((int)inputAr[0] - 48) * 10;
                Console.Write(DigitAsWord(digit));
                digit = 0;
                digit = ((int)inputAr[1] - 48);
                Console.Write("-{0}", DigitAsWord(digit));

            }
            else if (len == 3 && ((digit = (int)inputAr[1] - 48) == 0))
            {
                if (!((digit = (int)inputAr[2] - 48) == 0))
                {
                    digit = ((int)inputAr[0] - 48);
                    Console.Write("{0} hundred", DigitAsWord(digit));
                    digit = 0;
                    digit = (int)inputAr[2] - 48;
                    Console.Write(" and {0}", DigitAsWord(digit));
                }
                else
                {
                    digit = ((int)inputAr[0] - 48);
                    Console.Write("{0} hundred", DigitAsWord(digit));
                }

            }
            else if (len == 3 && (((digit = (int)inputAr[1] - 48) == 1) || (digit = (int)inputAr[2] - 48) == 0))
            {
                digit = ((int)inputAr[0] - 48);
                Console.Write("{0} hundred", DigitAsWord(digit));
                digit = 0;
                digit = ((int)inputAr[1] - 48) * 10 + (int)inputAr[2] - 48;
                Console.Write(" and {0}", DigitAsWord(digit));

            }
            else if (len == 3 && !(((digit = (int)inputAr[1] - 48) == 1) || (digit = (int)inputAr[2] - 48) == 0))
            {
                digit = ((int)inputAr[0] - 48);
                Console.Write("{0} hundred", DigitAsWord(digit));
                digit = 0;
                digit = ((int)inputAr[1] - 48) * 10;
                Console.Write(" and {0}", DigitAsWord(digit));
                digit = 0;
                digit = ((int)inputAr[2] - 48);
                Console.Write("-{0}", DigitAsWord(digit));
            }

            ///the following line is to keep the console open. You can press any key to exit the console.
            Console.ReadKey();
        }

        private static string DigitAsWord(int num)
        {

            switch (num)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                case 10: return "ten";
                case 11: return "eleven";
                case 12: return "twelve";
                case 13: return "thirteen";
                case 14: return "fourteen";
                case 15: return "fifteen";
                case 16: return "sixteen";
                case 17: return "seventeen";
                case 18: return "eighteen";
                case 19: return "nineteen";
                case 20: return "twenty";
                case 30: return "thirty";
                case 40: return "forty";
                case 50: return "fifty";
                case 60: return "sixty";
                case 70: return "seventy";
                case 80: return "eight";
                case 90: return "ninety";
                default: return "Invalid";

            }
        }
    }
}


