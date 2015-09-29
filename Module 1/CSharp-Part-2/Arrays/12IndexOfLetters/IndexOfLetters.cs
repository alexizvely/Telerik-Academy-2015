//Problem 12. Index of letters

//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class IndexOfLetters
{
    static void Main()
    {
        Console.Write("Please enter word with latin letters: ");
        var word = Console.ReadLine().ToUpper();
        char[] latinAlphabet = LatinAlphabetToArray();

        for (int i = 0; i < word.Length; i++)
        {
            int check = word[i] - 65;
            Console.WriteLine("Letter: {0}, Index: {1}", word[i], check);
        }

        Console.ReadKey();
    }

    public static char[] LatinAlphabetToArray()
    {
        char[] latinAlphabet = new char[26];

        for (int i = 0; i < 26; i++)
        {
            latinAlphabet[i] = (char)(65 + i);
        }
        return latinAlphabet;
    }
}

