//Problem 9. Exchange Variable Values
//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
//Print the variable values before and after the exchange.

using System;

class ExchangeVariableValues
{
    static void Main()
    {

        int a = 5;
        int b = 10;

        Console.WriteLine("The initial value for a is {0}\nThe initial value for b is {1}", a, b);

        ///Option 1:
        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine("The value for a is {0}\nThe value for b is {1}", a, b);

        ///Option 2:
        a = 5;
        b = 10;

        Console.WriteLine("\nThe initial value for a is {0}\nThe initial value for b is {1}", a, b);

        a ^= b ^= a;
        b = b - a ;
        Console.WriteLine("The value for a is {0}\nThe value for b is {1}", a, b);

        ///the following line is to keep the console open. You can press any key to exit the console.
        Console.ReadKey();
    }
}

