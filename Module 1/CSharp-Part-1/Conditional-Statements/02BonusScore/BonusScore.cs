//Problem 2. Bonus Score

//Write a program that applies bonus score to given score in the range [1…9] by the following rules:
//If the score is between 1 and 3, the program multiplies it by 10.
//If the score is between 4 and 6, the program multiplies it by 100.
//If the score is between 7 and 9, the program multiplies it by 1000.
//If the score is 0 or more than 9, the program prints “invalid score”.
//Examples:

//score	    result
//2	        20
//4	        400
//9	        9000
//-1	    invalid score
//10	    invalid score

using System;

class BonusScore
{
    static void Main()
    {

        Console.WriteLine("Please enter score: ");

        int score = int.Parse(Console.ReadLine());

        if ((1 > score) || (score > 9))
            Console.WriteLine("invalid score");
        else
        {
            switch (score)
            {
                case 1:
                case 2:
                case 3:
                    int sum = score * 10;
                    Console.WriteLine("result: {0}",sum); 
                    break;
                case 4:
                case 5:
                case 6:
                    sum = score * 100;
                    Console.WriteLine("result: {0}",sum); 
                    break;
                case 7:
                case 8:
                case 9:
                    sum = score * 1000;
                    Console.WriteLine("result: {0}", sum);
                    break;
                default:
                    Console.WriteLine("Error.");
                    break;
            }
        }

        ///the following line is to keep the console open. You can press any key to exit the console.
        Console.ReadKey();
    }
}

