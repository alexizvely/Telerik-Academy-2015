//Problem 2. Print Company Information

//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.
//Example input:

//program	            user
//Company name:	        Telerik Academy
//Company address:	    31 Al. Malinov, Sofia
//Phone number:	        +359 888 55 55 555
//Fax number:	
//Web site:	            http://telerikacademy.com/
//Manager first name:	Nikolay
//Manager last name:	Kostov
//Manager age:	        25
//Manager phone:	    +359 2 981 981

//Example output:

//Telerik Academy
//Address: 231 Al. Malinov, Sofia
//Tel. +359 888 55 55 555
//Fax: (no fax)
//Web site: http://telerikacademy.com/
//Manager: Nikolay Kostov (age: 25, tel. +359 2 981 981)  

using System;

    class PrintCompanyInformation
    {
        static void Main()
        {

            Console.Write("Company name: ");
            string compName = Console.ReadLine();

            Console.Write("Company address: ");
            string compAddress = Console.ReadLine();

            Console.Write("Company Phone: ");
            string compPhone = Console.ReadLine();

            Console.Write("Company fax: ");
            string compFax = Console.ReadLine();

            Console.Write("Company web site: ");
            string webSite = Console.ReadLine();

            Console.Write("Manager first name: ");
            string manFirstName = Console.ReadLine();

            Console.Write("Manager last name: ");
            string manLastName = Console.ReadLine();

            Console.Write("Manager age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Manager phone number: ");
            string manPhoneNum = Console.ReadLine();

            Console.WriteLine("\n---\nCompany Information: ");
            Console.WriteLine("\n{0}" +
                              "\nAddress: {1}" +
                              "\nTel. {2}" +
                              "\nFax: {3}" +
                              "\nWeb site: {4}" +
                              "\nManager: {5} {6} (age: {7}, tel. {8})", compName, compAddress, compPhone, compFax, webSite, manFirstName, manLastName, age, manPhoneNum
                              );

            ///the following line is to keep the console open. You can press any key to exit the console.
            Console.ReadKey();
        }
    }

