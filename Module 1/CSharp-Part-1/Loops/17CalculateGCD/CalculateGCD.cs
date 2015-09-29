//Problem 17.* Calculate GCD

//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
//Use the Euclidean algorithm (find it in Internet).
//Examples:

//a	b	GCD(a, b)
//3	2	1
//60	40	20
//5	-15	5


using System;

class CalculateGCD
{
    static void Main()
    {

        Console.WriteLine("The following calculates the greatest common divisor (GCD) of given two integers a and b.");
        Console.Write("Please enter first number: ");
        string str = Console.ReadLine();
        int firstNum = int.Parse(str);

        Console.Write("Please enter second number: ");
        str = Console.ReadLine();
        int secondNum = int.Parse(str);

        int gcd = 1;

        if (firstNum == 0)
        {
            Console.WriteLine("The GCD is " + secondNum);
        }
        else if (secondNum == 0)
        {
            Console.WriteLine("The GCD is " + firstNum);
        }
        else
        {
            if (firstNum < secondNum)
            {
                int temp = firstNum;
                firstNum = secondNum;
                secondNum = temp;
            }
            while (gcd != 0)
            {
                gcd = firstNum % secondNum;
                firstNum = secondNum;
                secondNum = gcd;
            }
            Console.WriteLine("GCD is " + firstNum);

        }

        Console.ReadKey();
    }
}

