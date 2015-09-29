using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class StudentsToStudentsAndBitsToBits
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());


        List<string> input = new List<string>();
        string output = "";
        long num = 0;

        for (int i = 1; i <= n; i++)
        {
            input.Add(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            num = Int32.Parse(input[i]);
            string binary = "";

            if (num == 0)
            {
                binary = "0";
            }
            while (num != 0)
            {
                binary = num % 2 + binary;
                num /= 2;
            }

            if (binary.Length < 30)
            {
                int count = 30 - binary.Length;
                for (int j = 0; j < count; j++)
                {
                    output = output + '0';
                } 
                output = output + binary;
            }
            else if (binary.Length == 30)
            {
                output = output + binary;
            }
            else
            {
                for (int j = 0; j < 31; j++)
                {
                    output = output + binary[0];
                }
            }

        }

        int count1 = 0;
        int count0 = 0;
        int temp1 = 0;
        int temp0 = 0;

        for (int i = 0; i < output.Length; i++)
        {

            if (output[i] == '0')
            {
                count0 = count0 + 1;
            }
            else if (output[i] == '1')
            {
                count1 = count1 + 1;
            }

            temp1 = Math.Max(temp1, count1);
            temp0 = Math.Max(temp0, count0);

            if (i != 0 && ((i+ 1) < output.Length) && output[i + 1] == '0' && output[i] == '1')
            {
                count1 = 0;
            }
            else if (i != 0 && ((i + 1) < output.Length) && output[i + 1] == '1' && output[i] == '0')
            {
                count0 = 0;
            }


        }

        Console.WriteLine(temp0);
        Console.WriteLine(temp1);
    }
}

