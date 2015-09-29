using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///// Constraints
//•	N will be a positive integer between 1 and 10 000.
//•	S will be a positive integer between 1 and 500.
//•	P will be a positive number between 0.01 and 100 with precision 2 digits after the decimal point.

class Printing
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine()); //students 
        int s = int.Parse(Console.ReadLine()); //number of paper sheets that should be printed for each student 
        decimal p = decimal.Parse(Console.ReadLine()); // price of one realm 

        ////You can buy part of a realm. For example if the price of a realm is 2.20 you can buy 0.45 parts 
        //of one realm which means that you will pay 0.45 * 2.20 = 0.99.

        decimal result = 0;

        result = n * s * (p/500);

        Console.WriteLine("{0:F2}", result);
        ///The output should be rounded with 2 digits after the decimal point.


    }
}

