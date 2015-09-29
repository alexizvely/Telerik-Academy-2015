//Problem 12. Null Values Arithmetic
//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

using System;

class NullValuesArithmetic
{
    static void Main()
    {

        int? intNullValue = null;
        double? doubleNullValue = null;
        Console.WriteLine("Int null value - {0}\nDouble null value - {1}", intNullValue, doubleNullValue);
        intNullValue += 3;
        doubleNullValue += 12;
        Console.WriteLine("Int null value + number - {0}\nDouble null value + number - {1}", intNullValue, doubleNullValue);
        intNullValue += 3;
        doubleNullValue += 12;
        Console.WriteLine("The previous result for int + number - {0}\nThe previous result for double + number - {1}", intNullValue, doubleNullValue);

        ///the following line is to keep the console open. You can press any key to exit the console.
        Console.ReadKey();
    }
}

