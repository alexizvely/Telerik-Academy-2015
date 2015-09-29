//Problem 12.* Randomize the Numbers 1…N

//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
//Examples:

//n	randomized numbers 1…n
//3	2 1 3
//10	3 4 8 2 6 7 9 1 10 5
//Note: The above output is just an example. Due to randomness, your program most probably will produce different results. You might need to use arrays.

using System;
using System.Linq;
using System.Collections.Generic;

    class RandomizeTheNumbersFrom1ToN
    {
        static void Main()
        {

            Console.WriteLine("The following prints the numbers 1, 2, …, n in random order");
            Console.Write("Please enter n (integer number): ");

            List<int> nums = new List<int>();
            int n = int.Parse(Console.ReadLine());
            int j = -1;
 
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    nums.Add(i);
                }
            }

            else if (n < -1)
            {
                nums.Add(1);
                nums.Add(0);
                nums.Add(-1);
                while (j != (n - 1))
                {

                    nums.Add(j);
                }
            }

            else
            {
                Console.WriteLine(1);
                if (n == 0)
                {
                    nums.Add(0);
                }
                else
                {

                    nums.Add(0);
                    nums.Add(-1);
                }
            }

            Random rnd = new Random();
            List<int> output = new List<int>();

            int count = 0;
            bool contains = false;

            int ind = 0;

            do
            {
                ind = rnd.Next(0, n);

                contains = output.Contains(nums[ind]);

                if (!contains)
                {
                    output.Add(nums[ind]);
                    count = count + 1;
                }

            } while (count < n);



            Console.Write(output[0]);

            for (int i = 1; i < output.Count; i++)
            {
                Console.Write(" {0}", output[i].ToString());
            }

            Console.ReadKey();
        }
    }

