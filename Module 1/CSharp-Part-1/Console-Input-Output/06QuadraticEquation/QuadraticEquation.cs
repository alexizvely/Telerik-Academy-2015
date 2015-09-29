//Problem 6. Quadratic Equation

//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
//Examples:

//a	     b	    c	    roots
//2	     5	    -3	    x1=-3; x2=0.5
//-1	 3	    0	    x1=3; x2=0
//-0.5	 4	    -8	    x1=x2=4
//5	     2	    8	    no real roots

using System;
using System.Globalization;

class QuadraticEquation
{
    static void Main()
    {
        CultureInfo invC = CultureInfo.InvariantCulture;

        Console.WriteLine("Quadratic equation is any equation having the form \n\rax^2+bx+c=0 \n\rwhere x represents an unknown, and a, b, and \n\rc represent known numbers such that a is not equal to 0");
        Console.WriteLine("This project will solve a quadratic equation and print its real roots");

        Console.Write("Please enter a:");
        double a = double.Parse(Console.ReadLine(), invC);

        Console.Write("Please enter b:");
        double b = double.Parse(Console.ReadLine(), invC);

        Console.Write("Please enter c:");
        double c = double.Parse(Console.ReadLine(), invC);

        double point = Math.Pow(b, 2) - 4 * a * c;

        if (point < 0)
        {
            Console.WriteLine("no real roots");
        }
        else if (point == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("x1 = x2 = {0}", x);
        }
        else
        {
            double x1 = (-b + Math.Sqrt(point)) / (2 * a);
            double x2 = (-b - Math.Sqrt(point)) / (2 * a);
            Console.WriteLine("x1 = {0}\nx2 = {1}", x1, x2);
        }

        ///the following line is to keep the console open. You can press any key to exit the console.
        Console.ReadKey();
    }
}

