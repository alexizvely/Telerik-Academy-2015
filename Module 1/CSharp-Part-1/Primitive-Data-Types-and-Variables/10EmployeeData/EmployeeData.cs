//Problem 10. Employee Data
//A marketing company wants to keep record of its employees. Each record would have the following characteristics:

//First name
//Last name
//Age (0...100)
//Gender (m or f)
//Personal ID number (e.g. 8306112507)
//Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.

///// I didn't had enough time and knowledge to put validations to every input for now. :(
///// Please note that validations are not required as per the task.
//// Thank you!

using System;

class EmployeeData
{
    static void Main()
    {

        string firstName = "";
        string lastName = "";
        byte age = 0;
        string ageStr;
        string gender = "";
        long personIdNum = 0;
        long uniqEmplNum = 0;

        int switcher = 1;


        object[] array = new object[6];
        for (int lineCount = 0; lineCount < 6; lineCount = lineCount +1)
        {
            bool check = false;
            switch (switcher)
            {
                case 1:                  
                           
                            Console.WriteLine("\nPlease input First Name: ");
                            check = System.ConsoleKeyInfo.ReferenceEquals(Console.ReadKey(), System.ConsoleKey.Enter);
                            firstName = Console.ReadLine();
                            array[lineCount] = firstName;
                            switcher++;
                   break;
                case 2:

                           Console.WriteLine("\nPlease input Last Name: ");
                           lastName = Console.ReadLine();
                           array[lineCount] = lastName;
                           switcher++;

                   break;
                case 3:

                       Console.Write("\nPlease input age (from 0 to 100). Please input the number twice. (Thank you!): \n");
                       ageStr = Console.ReadLine();

                       if (Byte.TryParse(ageStr, out age) == false)
                       {
                           Console.Write("\nPlease input valid number for age (from 0 to 100).");
                           goto case 3;

                       }
                       else
                       {
                           age = Byte.Parse(Console.ReadLine());
                           if (age < 100 && age > 0)
                           {
                               age = Byte.Parse(ageStr);
                               array[lineCount] = age;
                               switcher++;
                           }
                           else
                           {
                               Console.Write("\nPlease input valid number for age (from 0 to 100).");

                           }
                       }
                       break;
                case 4:

                       Console.WriteLine("Please input gender (m/f): ");

                       gender = Console.ReadLine();
                       array[lineCount] = gender;
                       switcher++;

                   break;
                case 5:

                   Console.WriteLine("Please input Personal ID number (from 0 to 100 000 000 000): ");

                       personIdNum = long.Parse(Console.ReadLine());
                       array[lineCount] = personIdNum;
                       switcher++;

                   break;
                case 6:

                   Console.WriteLine("Please input Unique employee number (from 0 to 100 000 000 000): ");

                       uniqEmplNum = long.Parse(Console.ReadLine());
                       array[lineCount] = uniqEmplNum;
                       switcher++;

                   break;

                default:
                   Console.WriteLine("1");
                   break;
            }
        }

        Console.Write("\n\nEmployee info:\n\n");
        for (int i = 0; i < array.Length; i++)
        {

            Console.Write("\n{0}\n", array[i] );
        }

        ///the following line is to keep the console open. You can press any key to exit the console.
        Console.ReadKey();
        

    }
}

