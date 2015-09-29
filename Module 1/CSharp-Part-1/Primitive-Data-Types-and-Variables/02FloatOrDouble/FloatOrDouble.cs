//Problem 2. Float or Double?
//Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
//Write a program to assign the numbers in variables and print them to ensure no precision is lost.

using System;

class FloatOrDouble
{
    static void Main()
    {

        double numberOne = 34.567839023;
        float numberTwo = 12.345f;
        double numberThree = 8923.1234857;
        float numberFour = 3456.091f;

        Console.WriteLine("{0} is in double data type. \nDouble has range -1.79769313486232e308 .. 1.79769313486232e308 with precision of 15-16 digits. \n\n{1} is in float data type. \nFloat has range -3.402823e38 .. 3.402823e38 with precision of 7 digits. \n\n{2} is in double data type. \nDouble has range -1.79769313486232e308 .. 1.79769313486232e308 with precision of 15-16 digits. \n\n{3} is in float data type. \nFloat has range -3.402823e38 .. 3.402823e38 with precision of 7 digits.", numberOne, numberTwo, numberThree, numberFour);

        ///the following line is to keep the console open. You can press any key to exit the console.
        Console.ReadKey();
    }
}

