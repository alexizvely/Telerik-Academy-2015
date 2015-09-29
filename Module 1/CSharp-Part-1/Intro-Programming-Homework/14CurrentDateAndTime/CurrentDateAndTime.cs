///Problem 14.* Current Date and Time
///Create a console application that prints the current date and time. Find out how in Internet.

using System;

class CurrentDateAndTime
{
    static void Main()
    {

            ///creates variable dateNow which holds the value of the current date
        DateTime dateNow = DateTime.Now;
            ///prints the value of dateNow
        Console.WriteLine(dateNow);
            ///the following line is to keep the console open. You can press any key to exit the console.
        Console.ReadKey();
    }
}

