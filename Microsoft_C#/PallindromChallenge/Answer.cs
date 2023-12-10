using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PallindromChallenge
{
    public class Answer
    {
        // Change these Boolean values to control whether you see 
        // the expected result and/or hints.
        public static Boolean ShowExpectedResult = false;
        public static Boolean ShowHints = false;

        // Determine whether a string is a Palindrome
        public static bool IsPalindrome(string str)
        {
            // Your code goes here.
            var sb = new StringBuilder();
            string testStr = str.ToLower();

            foreach (char ch in testStr)
            {
                if (!char.IsWhiteSpace(ch) && !char.IsPunctuation(ch))
                {
                    sb.Append(ch);
                }
            }
            int len = sb.Length;
            int index_last_digit = len;

            for (int i = 0; i < len / 2; i++, index_last_digit--)
            {
                if (sb[i] != sb[index_last_digit - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
