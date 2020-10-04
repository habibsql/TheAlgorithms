using System;
using System.Collections.Generic;
using System.Text;

namespace TheAlgorithms.StringRelated.Permutation
{
    public class Permutation
    {
        public void DoPermutation(string perm, string word, List<string> permutationList)
        {
            if (string.IsNullOrEmpty(word))
            {
                permutationList.Add(string.Concat(perm, word));
            }
            else
            {
                for (int i = 0; i < word.Length; i++)
                {
                    var p = perm + word[i];
                    var w = word.Substring(0, i) + word.Substring(i+1);
                    DoPermutation(p, w, permutationList);
                }
            }
        }
    }
}
