//Problem 11. Bank Account Data
//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;

class BankAccountData
{
    static void Main()
    {

        DateTime date = DateTime.Now;
        Console.WriteLine("Welcome to First VM Bank | {0}", date);
        Console.WriteLine();
        Console.Write("Please enter your username:");
        string userName = Console.ReadLine();
        Console.WriteLine("Hello, {0} !", userName);
        Console.WriteLine();
        string holderNames = "Mr. Potter";
        float amoutOfMoney = 200.0f;
        string bankName = "FVMB";
        string iBan = "BG 28 BNBG 9661 4478 1320 01";
        long creditCard1 = 4543543543543543;
        long creditCard2 = 6678678678787689;
        long creditCard3 = 3423423423423449;
        Console.WriteLine("Holder name - {0}, available amount: {1} BGN at '{2}' Bank", holderNames, amoutOfMoney, bankName);
        Console.WriteLine("IBAN:{0} \nHolder credit card numbers: \nCard 01 - {1} \nCard 02 - {2} \nCard 03 - {3}", iBan, creditCard1, creditCard2, creditCard3);

        ///the following line is to keep the console open. You can press any key to exit the console.
        Console.ReadKey();
    }
}

