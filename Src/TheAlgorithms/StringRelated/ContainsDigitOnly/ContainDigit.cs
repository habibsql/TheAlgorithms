using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace TheAlgorithms.StringRelated.ContainsDigitOnly
{
    public class ContainDigit
    {

        /// <summary>
        /// Checking wither input string contain only digit or not using regular expression
        /// </summary>
        /// <param name="input"></param>
        /// <returns>if only digit then true else false</returns>
        public bool IsContainOnlyDigit(string input)
        {
            string pattern = @"^\d+$";
            var regex = new Regex(pattern);

            Match match = regex.Match(input);

            return match.Success;
        }

        /// <summary>
        /// Checking wither input string contain only digit or not using iteration approach
        /// </summary>
        /// <param name="input"></param>
        /// <returns>if only digit then true else false</returns>
        public bool IsContainOnlyDigitV2(string input)
        {
            char[] characters = input.ToCharArray();

            char[] digits = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            foreach(char character in characters)
            {
                if (!digits.Contains(character))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
