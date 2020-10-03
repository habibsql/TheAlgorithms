using System;
using System.Collections.Generic;
using System.Text;

namespace TheAlgorithms.StringRelated.Reverse
{
    public class Reverse
    {
        public string ReverseString(string input)
        {
            char[] chars = input.ToCharArray();
            int length = chars.Length;

            var reverseStringBuilder = new StringBuilder();

            for(int index = length - 1; index >=0; index--)
            {
                reverseStringBuilder.Append(chars[index]);
            }

            return reverseStringBuilder.ToString();
        }
    }
}
