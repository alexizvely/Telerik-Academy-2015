﻿using System;

/* We are given a string containing a list of forbidden words and a text containing some of these words.
Write a program that replaces the forbidden words with asterisks.
 * Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 
 * and is implemented as a dynamic language in CLR.
Forbidden words: PHP, CLR, Microsoft
The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 
 * and is implemented as a dynamic language in ***.*/
class ForbiddenWords
{
    static void Main()
    {
        string text = @"Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string[] forbiddenWords = {"PHP", "CLR", "Microsoft"};
        string[] splitedText=text.Split(new char []{' ',',','.',},StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < forbiddenWords.Length; i++)
        {
            int found = text.IndexOf(forbiddenWords[i]);
            if (found>=0)
            {
                text = text.Replace(forbiddenWords[i], new string('*', forbiddenWords[i].Length));
            }
        }
        Console.WriteLine(text);
    }
}
