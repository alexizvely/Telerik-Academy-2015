﻿//Problem 13.* Comparing Floats
//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
//Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.
//Examples:

//Number a	    Number b	Equal (with precision eps=0.000001)	Explanation
//5.3	6.01	            false	                            The difference of 0.71 is too big (> eps)
//5.00000001	5.00000003	true	                            The difference 0.00000002 < eps
//5.00000005	5.00000001	true	                            The difference 0.00000004 < eps
//-0.0000007	0.00000007	true	                            The difference 0.00000077 < eps
//-4.999999	    -4.999998	false	                            Border case. The difference 0.000001 == eps. We consider the numbers are different.
//4.999999	    4.999998	false	                            Border case. The difference 0.000001 == eps. We consider the numbers are different.

using System;

class ComparingFloats
{
    static void Main()
    {

        double[] arrayOne = new double[] { 5.3, 5.00000001, 5.00000005, -0.0000007, -4.999999, 4.999999 };
        double[] arrayTwo = new double[] { 6.01, 5.00000003, 5.00000001, 0.00000007, -4.999998, 4.999998 };

        for (int i = 0; i <= arrayOne.Length; i++)
        {

            bool equal = Math.Abs(arrayOne[i] - arrayTwo[i]) < 0.000001;
            Console.WriteLine("The numbers \t{0} \tand \t{1} \tare equal: \t{2}.", arrayOne[i].ToString("0.00000000"), arrayTwo[i].ToString("0.00000000"), equal ? "True" : "False");
        }
        ///the following line is to keep the console open. You can press any key to exit the console.
        Console.ReadKey();
    }
}

