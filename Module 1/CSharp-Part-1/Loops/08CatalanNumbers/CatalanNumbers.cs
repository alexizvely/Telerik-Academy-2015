//Problem 8. Catalan Numbers

//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).
//Examples:

//n	    Catalan(n)
//0	    1
//5	    42
//10	16796
//15	9694845

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {

        Console.WriteLine("The following calculates Catalan(n)");
        Console.Write("Please enter N (integer number): ");
        double n = double.Parse(Console.ReadLine());

        double n1 = n + 1;
        double n2 = 2 * n;
        BigInteger nFact = 1;
        BigInteger nFact1 = 1;
        BigInteger n2Fact = 1;
        BigInteger result = 0;


            for (int i = 1; i <= n2; i++)
            {


                n2Fact = n2Fact * i;

                if (n1 < i)
                {
                    continue;
                }

                nFact1 = nFact1 * i;
                if (n < i)
                {
                    continue;
                }

                nFact = nFact * i;
            }

            result = n2Fact / (nFact1 * nFact); 
        

        Console.WriteLine("Catalan(n): {0}", result);
        Console.ReadKey();
    }
}

