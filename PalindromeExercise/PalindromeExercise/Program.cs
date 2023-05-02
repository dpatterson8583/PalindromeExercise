using System;

namespace PalindromeExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            var w = new WordSmith();

            Console.WriteLine($"abcdefg is a Palindrome {w.IsAPalindrome("abcdefg")} ");
        }
    }
}