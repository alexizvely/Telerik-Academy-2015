///Problem 15.* Age after 10 Years
///Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

using System;
using System.Globalization;
using System.Threading;

class AgeAfterTenYears
{
    static void Main()
    {

/// Please note that there is Scheme of the following saved in the Main solution folder as a JPG file.
        CultureInfo cultureInfo = new CultureInfo("bg-BG");
            ///Provides information about a specific culture (called a locale for unmanaged code development). The information includes the names for the culture, the writing system, the calendar used, and formatting for dates and sort strings.
            /// Link to MSDN for further information: http://msdn.microsoft.com/en-us/library/ky2chs3h(v=vs.110).aspx
        Thread.CurrentThread.CurrentCulture = cultureInfo;
            ///Description from MSDN: Gets or sets the culture for the current thread.
            /// Link to MSDN for further information: http://msdn.microsoft.com/en-us/library/system.threading.thread.currentculture%28v=vs.110%29.aspx

        DateTime dateBirth;
            ///the following 3 lines: we decalre 3 variables - for current year, for current month and current day.
        int yearNow = (int)DateTime.Now.Year;
        byte monthNow = (byte)DateTime.Now.Month;
        byte dayNow = (byte)DateTime.Now.Day;
            ///the following 3 lines: we decalre 3 variables - for year of birth, for month of birth and day of birth.
        int yearBirth;
        byte monthBirth;
        byte dayBirth;

        int age = 0; /// this is the variable that will hold age after 10 years.
        
        Console.WriteLine("Please input your birth date in format DD/MM/YYYY or DD.MM.YYYY or DD,MM,YYYY");
        Console.WriteLine("Please note that the date need to be after 01.01.1900 and prior today's date.\nCurrent date is {0}.{1}.{2}. (format: dd.mm.yyyy)", dayNow, monthNow, yearNow);
        ///the following line: dateString variable takes the value form our input in the console.
        string dateString = Console.ReadLine();
        {
            while (age==0)
                /// Description from MSDN: The while statement executes a statement or a block of statements until a specified expression evaluates to false.
                /// Link to MSDN for further information: http://msdn.microsoft.com/en-us/library/2aeyhxcd.aspx
                /// Due to the fact that variable age will not receive any value until the input date is in the exact format required - the console will keep asking for the correct date format until the input date is in the appropriate format so it to be able to continue further with the code.
            {


                if ((DateTime.TryParse(dateString, out dateBirth)) == false) ///if the input date is Not in the exact format required.
                    ///TryParse(String, DateTime)	->>> Description from MSDN: Converts the specified string representation of a date and time to its DateTime equivalent and returns a value that indicates whether the conversion succeeded.
                    /// Link to MSDN for further information: http://msdn.microsoft.com/en-us/library/ch92fbc1(v=vs.110).aspx
                {

                    Console.WriteLine("Error. Please read the following instructions and insert your birth date."); /// returns "Error"if the input date is not in the exact format required. 
                    Console.WriteLine("Please input your birth date in format DD/MM/YYYY or DD.MM.YYYY or DD,MM,YYYY");
                    dateString = Console.ReadLine();
                }

                else ///hence, the input date is in the exact format required.
                {

                        ///then the following variables get the following values.
                    yearBirth = (int)dateBirth.Year;
                    monthBirth = (byte)dateBirth.Month;
                    dayBirth = (byte)dateBirth.Day;

                    if (((1900 < yearBirth) && (yearBirth < yearNow))|| ((yearBirth == yearNow) && ((monthNow > monthBirth) || ((monthNow == monthBirth) && (dayNow >= dayBirth))))) /// we will check wether the input date has already passed. Hence, if it is indeed a birth date of someone who has already been born. Also, we will check wether the date is after 01.01.1900.
                    {
                        if ((monthNow < monthBirth) || ((monthNow == monthBirth) && (dayNow < dayBirth))) ///if the birthday has already passed this year then we increase the year of birth with one in order to reflect the fact that the person hasn't had birthday this year yet.
                        {

                            yearBirth = (int)dateBirth.Year + 1;
                        }   

                        else ///nothing changes.
                        {

                            yearBirth = (int)dateBirth.Year;
                        }

                            age = yearNow - yearBirth + 10; ///based on the results from above - we calculate the value for age.
                            Console.WriteLine("You are {0} years old. You will be {1} years old at this date after 10 years.", age-10,age);
                        }
                    else /// if the input date is for the future
                    {
                            Console.WriteLine("Please input birth date for person that has already been born.\nCurrent date is {0}.{1}.{2}. (format: dd.mm.yyyy)", dayNow, monthNow, yearNow);
                            Console.WriteLine("Please input birth date in format DD/MM/YYYY or DD.MM.YYYY or DD,MM,YYYY");
                            dateString = Console.ReadLine();
                            age = 0;
                    }
                }
            }
        }

            ///the following line is to keep the console open. You can press any key to exit the console.
        Console.ReadKey();

    }
}
