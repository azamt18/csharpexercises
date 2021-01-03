using System;

namespace CSharpExercises.Strings
{
    public class NumberOfWords
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfWordsMethod("This is sample sentence")); //  → 4
            Console.WriteLine(NumberOfWordsMethod("OK")); //  → 4

            Console.ReadKey();
        }

        static int NumberOfWordsMethod(string str)
        {
            int counter = 0;
            foreach (var c in str)
            {
                if (c == ' ')
                    counter++;
            }

            return ++counter;
        }
    }
}