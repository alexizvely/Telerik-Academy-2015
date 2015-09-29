//Problem 7. Quotes in Strings
//Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
//Do the above in two different ways - with and without using quoted strings.
//Print the variables to ensure that their value was correctly defined.

using System;

class QuotesInStrings
{
    static void Main()
    {

        string withQuotedString ="The \"use\" of quotations causes difficulties.";
        string withoutQuotedString = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine("With Quoted String: \n{0}\n\nWithout Quoted String: \n{1}", withQuotedString, withoutQuotedString);

            ///the following line is to keep the console open. You can press any key to exit the console.
        Console.ReadKey();
    }
}

