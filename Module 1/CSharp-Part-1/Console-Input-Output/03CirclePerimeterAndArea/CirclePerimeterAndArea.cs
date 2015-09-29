//Problem 3. Circle Perimeter and Area

//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
//Examples:

//r	    perimeter	area
//2	    12.57	    12.57
//3.5	21.99	    38.48

using System;
using System.Globalization;

class CirclePerimeterAndArea
    {
        static void Main()
        {

            CultureInfo invC = CultureInfo.InvariantCulture;

            Console.Write("Circle radius (r): ");
            double r = double.Parse(Console.ReadLine(), invC);
            double P = 2 * Math.PI * r;

            Console.WriteLine("Perimeter: {0:N2}", P);

            double S = Math.PI * r * r;

            Console.WriteLine("Area: {0:N2}", S);

            ///the following line is to keep the console open. You can press any key to exit the console.
            Console.ReadKey();
        }
    }

