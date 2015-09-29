//Problem 9. Play with Int, Double and String

//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.
//Example 1:

//program	                user
//Please choose a type:	
//1 --> int	
//2 --> double	
//3 --> string	            3
//Please enter a string:	hello
//hello*

//Example 2:

//program	                user
//Please choose a type:	
//1 --> int	
//2 --> double	            2
//3 --> string	
//Please enter a double:	1.5
//2.5	

using System;
using System.Globalization;

class PlayWithIntDoubleAndString
{
    static void Main()
    {

        CultureInfo invC = CultureInfo.InvariantCulture;

        Console.WriteLine("Please choose a type:");
        Console.Write("1-->int\n2-->double\n3-->string\n");

        string input = Console.ReadLine();
        switch (input)
        {
            case "1":
                Console.Write("int: ");
                int a = int.Parse(Console.ReadLine());
                int sumI = a + 1;
                Console.WriteLine(sumI); 
                break;
            case "2": Console.Write("double: ");
                double b = double.Parse(Console.ReadLine(), invC);
                double sumD = b + 1;
                Console.WriteLine(sumD); 
                break;
            case "3": Console.Write("string:");
                string strRes = Console.ReadLine();
                Console.WriteLine(strRes + "*"); 
                break;
            default:
                Console.WriteLine("Error. You have not selected a type.");
                break;
        }

        ///the following line is to keep the console open. You can press any key to exit the console.
        Console.ReadKey();
    }
}

