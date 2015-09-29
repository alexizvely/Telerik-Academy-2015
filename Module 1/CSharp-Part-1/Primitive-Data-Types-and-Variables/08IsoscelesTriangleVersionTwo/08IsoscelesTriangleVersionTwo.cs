//Problem 8. Isosceles Triangle
//Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
//   ©

//  © ©

// ©   ©

//© © © ©
//Note: The © symbol may be displayed incorrectly at the console so you may need to change the console character encoding to UTF-8 and assign a Unicode-friendly font in the console.
//Note: Under old versions of Windows the © symbol may still be displayed incorrectly, regardless of how much effort you put to fix it.

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/// Please note that this is the second version of this program, which I used only to practice switch statement. There is no need to review it if you are busy.


//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;

class IsoscelesTriangleVersionTwo
{
    static void Main()
    {

        Console.OutputEncoding = System.Text.Encoding.UTF8;

        ////4, 3, 5, 2, 6, 1, 3, 5, 7
        string symBlank = " ";
        string symCopy = "©";

        /// Description from MSDN: You can store multiple variables of the same type in an array data structure. You declare an array by specifying the type of its elements.
        /// Link to MSDN for further information: http://msdn.microsoft.com/en-us/library/aa288453%28v=vs.71%29.aspx
        /// Link to MSDN for further information: http://msdn.microsoft.com/en-us/library/9b9dty7d.aspx
        string[] line = new string[7];

        int isEven = 1;
        int lineSymPlace = 0;
        bool isValid = true;

            /// Description from MSDN: The while statement executes a statement or a block of statements until a specified expression evaluates to false.
            /// Link to MSDN for further information: http://msdn.microsoft.com/en-us/library/2aeyhxcd.aspx
            /// Due to the fact that variable age will not receive any value until the input date is in the exact format required - the console will keep asking for the correct date format until the input date is in the appropriate format so it to be able to continue further with the code.
        while (isValid == true && isEven < 9)
        {

            for (int i = 0; i < 8; i++)
            {
                isEven++;
                 ///we reset the array "line" to blank in the following for loop
                for (int j = 0; j < line.Length; j++)
                {
                    line[j] = symBlank;
                }
                    /// if the row is even (please note that we start counting from 2) then we use switch case (4 different cases for each non-blank row). Please note that each case is followed by empty line as per assignment. Else: we just fill in with blank symbol on a single row.
                if (isEven % 2 == 0)
                {
                        //Description from MSDN: The switch statement is a control statement that selects a switch section to execute from a list of candidates.
                        //A switch statement includes one or more switch sections. Each switch section contains one or more case labels followed by one or more statements. The following example shows a simple switch statement that has three switch sections. Each switch section has one case label, such as case 1, and two statements.
                        //Link to MSDN for further information: http://msdn.microsoft.com/en-us/library/06tc147t.aspx
                    switch (isEven)
                    {
                        case 2:
                            lineSymPlace = (isEven + 4) / isEven;
                            line[lineSymPlace] = symCopy;
                            break;

                        case 4:
                            lineSymPlace = (isEven + 1) / isEven + 1;
                            line[lineSymPlace] = symCopy;
                            lineSymPlace = lineSymPlace + isEven - 2;
                            line[lineSymPlace] = symCopy;
                            break;

                        case 6:
                            lineSymPlace = (isEven + 1) / isEven;
                            line[lineSymPlace] = symCopy;
                            lineSymPlace = isEven - 1;
                            line[lineSymPlace] = symCopy;
                            break;

                        case 8:
                            lineSymPlace = 0;
                            line[lineSymPlace] = symCopy;
                            lineSymPlace += 2;
                            line[lineSymPlace] = symCopy;
                            lineSymPlace += 2;
                            line[lineSymPlace] = symCopy;
                            lineSymPlace += 2;
                            line[lineSymPlace] = symCopy;
                            break;

                        default:
                            Console.WriteLine("Error");
                            isValid = false;
                            break;
                    }

                    for (int k = 0; k < line.Length; k++)
                    {
                        Console.Write("{0}", line[k]);
                    }
                    Console.WriteLine();
                }
                else
                {
                        Console.WriteLine ("{0}", line[0]);
                }
            }
                ///the following line is to keep the console open. You can press any key to exit the console.
            Console.ReadKey();
        }
    }

}