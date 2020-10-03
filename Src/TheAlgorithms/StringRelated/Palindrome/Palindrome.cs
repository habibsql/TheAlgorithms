using System;
using System.Collections.Generic;
using System.Text;

namespace TheAlgorithms.StringRelated.Palindrome
{
    public class Palindrome
    {
        /// <summary>
        /// Recursively
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool IsPalendrome(string input)
        {
            if (input.Length <= 1)
            {
                return true;
            }

            if (input[0] != input [input.Length - 1])
            {
                return false;
            }

            return IsPalendrome(input.Substring(1, input.Length - 2));
        }
        /// <summary>
        /// Iterative way
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool IsPalendromeIterative(string input)
        {
            char[] chars = input.ToCharArray();
            int n = chars.Length;

            for(int i=0, j=n-1; i < n/2; i++, j--)
            {
                if (chars[i] != chars[j])
                {
                    return false;
                }
            }

            return true;
        }

    }
}
