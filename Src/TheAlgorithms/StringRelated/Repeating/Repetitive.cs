using System;
using System.Collections.Generic;
using System.Text;

namespace TheAlgorithms.StringRelated.Repeating
{
    public class Repetitive
    {
        /// <summary>
        /// Count no of occerence of each character
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public Dictionary<string, int> CountRepetitiveCharacters(string word)
        {
            char[] chars = word.ToCharArray();
            int n = chars.Length;

            var charCountDictionary = new Dictionary<string, int>();

            for(int i=0; i < n; i++)
            {
                char c = chars[i];

                if (charCountDictionary.ContainsKey(c.ToString()))
                {
                    int value = charCountDictionary[c.ToString()];
                    charCountDictionary[c.ToString()] = value + 1;
                }
                else
                {
                    charCountDictionary.Add(c.ToString(), 1);
                }
            }

            return charCountDictionary;
        }

    }
}
