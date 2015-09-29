using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class SaddyKopper
{
    static void Main()
    {

        string input = Console.ReadLine();

        int count = input.Length - 1;

        BigInteger result = 0;
        BigInteger product = 1;
        long sum = 0;
        char checker;
        int transformation = 0;
        bool contin = false;

        do
        {
            do
            {
                sum = 0;
                for (int i = 0; i < count; i++)
                {
                    checker = input[i];

                    if (i % 2 == 0)
                    {
                        switch (checker)
                        {
                            case '0': sum = sum + 0; break;
                            case '1': sum = sum + 1; break;
                            case '2': sum = sum + 2; break;
                            case '3': sum = sum + 3; break;
                            case '4': sum = sum + 4; break;
                            case '5': sum = sum + 5; break;
                            case '6': sum = sum + 6; break;
                            case '7': sum = sum + 7; break;
                            case '8': sum = sum + 8; break;
                            case '9': sum = sum + 9; break;
                            default: break;
                        }

                        if (count % 2 == 1 && i == count - 1)
                        {
                            product = product * sum;
                            count = count - 1;
                        }
                        else if (count % 2 == 0 && i == count - 2)
                        {
                            product = product * sum;
                            count = count - 1;
                        }
                    }
                }

            } while (count >= 1);

            input = product.ToString();

            count = input.Length - 1;
            result = product;

            if (result > 9)
            {
                contin = true;
                product = 1;
            }
            else if (result < 10)
            {
                contin = false;
                result = product;
            }
            transformation++;

            if (transformation == 10)
            {
                Console.WriteLine(result);
            }
        } while (transformation < 10 && contin);

        if (transformation < 10)
        {
            Console.WriteLine(transformation);
            Console.WriteLine(result);

        }
        
    }

}




