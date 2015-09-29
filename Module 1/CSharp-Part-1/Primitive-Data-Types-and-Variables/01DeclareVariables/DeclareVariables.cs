///Problem 1. Declare Variables
//Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
//Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
//Submit the source code of your Visual Studio project as part of your homework submission.

using System;

class DeclareVariables
{
    static void Main()
    {

        ushort numberOne = 52130;
        sbyte numberTwo = -115;
        uint numberThree = 4825932;
        byte numberFour = 97;
        int numberFive = -10000;

        Console.WriteLine("{0} is in ushort data type. Ushort has range 0 .. 65,535 \n\n{1} is in sbyte data type. Sbyte has range -128 .. 127 \n\n{2} is in uint data type. Uint has range 0 .. 4,294,967,295 \n\n{3} is in byte data type. Byte has range 0 .. 255 \n\n{4} is in int data type. Int has range -2,147,483,648 .. 2,147,483,647", numberOne, numberTwo, numberThree, numberFour, numberFive);

            ///the following line is to keep the console open. You can press any key to exit the console.
        Console.ReadKey();
    }
}

