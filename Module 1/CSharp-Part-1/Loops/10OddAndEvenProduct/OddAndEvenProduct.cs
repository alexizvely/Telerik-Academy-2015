//Problem 10. Odd and Even Product

//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
//Examples:

//numbers	            result
//2 1 1 6 3	            yes
//product = 6	
//3 10 4 6 5 1	        yes
//product = 60	
//4 3 2 5 2	            no
//odd_product = 16	
//even_product = 15	

using System;

class OddAndEvenProduct
{
    static void Main()
    {

        Console.WriteLine("The following checks whether the product of the odd elements is equal to the product of the even elements");
        Console.Write("Please enter n integers (given in a single line, separated by a space): ");

        string input = Console.ReadLine();
        string[] inArr = input.Split(' ');
        long[] intArr = Array.ConvertAll(inArr, long.Parse);
        long prodEv = 1;
        long prodOd = 1;

        for (int i = 0; i < intArr.Length; i++)
        {
            if ((i+1) % 2 == 0)
            {
                prodEv = prodEv * intArr[i];
            }
            else if ((i + 1) % 2 != 0)
            {
                prodOd = prodOd * intArr[i];
            }
        }


        if (prodOd == prodEv)
        {
            Console.WriteLine("result: yes");
        }
        else
        {
            Console.WriteLine("result: no");
        }
        Console.WriteLine("odd_product: {0}", prodOd);
        Console.WriteLine("odd_product: {0}", prodEv);
        Console.ReadKey();
    }
}

