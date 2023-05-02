using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public WordSmith() { }

        public bool IsAPalindrome(string word)
        {
            var j = word.Length-1;
            var w = word.ToLower();

            for(int i = 0; i < w.Length; i++)
            {   

                if (w[i] != w[j])  return false ; 
                else
                {
                    j--;
                    if (i + 1 == j ||  i == j) return true;
                }
            }

            return false;
        }
    }
}
