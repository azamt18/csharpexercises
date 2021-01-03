using System;

namespace CSharpExercises.Strings
{
    class IsPalindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindromeMethod("eye"));  // True
            Console.WriteLine(IsPalindromeMethod("home")); // False

            Console.WriteLine(IsPalindromeMethod("madam")); // True
            Console.WriteLine(IsPalindromeMethod("123454321")); // True
            Console.WriteLine(IsPalindromeMethod("apple")); // False
            Console.WriteLine(IsPalindromeMethod("Curabitur vel est diam")); // False
            Console.WriteLine(IsPalindromeMethod("x")); // True

            Console.ReadLine();
        }

        static bool IsPalindromeMethod(string word)
        {

            bool isPalindrome = true;

            word = word.ToLower();

            for (int i = 0; i < word.Length / 2; i++)
            {
                isPalindrome = word[i] == word[word.Length - 1 - i];
                 if (isPalindrome == false)
                    break;
            }

            return isPalindrome;
        }
    }
}
