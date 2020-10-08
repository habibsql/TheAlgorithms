using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TheAlgorithms.ArrayRelated.DuplicateRemove
{
    public class DuplicateRemove
    {
        /// <summary>
        /// Remove duplicate items from a given array using Set
        /// </summary>
        /// <param name="array">array with duplicate items</param>
        /// <returns>an array of unique items</returns>
        public int[] RemoveDuplicateItem(int[] array)
        {
            var items = new HashSet<int>();

            for (int index = 0; index < array.Length; index++)
            {
                items.Add(array[index]);
            }

            int[] uniqueArray = new int[items.Count];

            items.CopyTo(uniqueArray);

            return uniqueArray;
        }


        /// <summary>
        /// Remove duplicate items from a given array using Basic technique
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int[] RemoveDuplicateItemBasic(int[] array)
        {
            int[] uniqueArray = new int[array.Length];
            int k = 0;
            uniqueArray[k] = array[k];

            for (int i = 0; i < array.Length; i++)
            {
                bool found = false;
                for (int j = 0; j < uniqueArray.Length; j++)
                {
                    if (array[i] == uniqueArray[j])
                    {
                        found = true;
                        break;
                    }                    
                }

                if (!found)
                {
                    k++;
                    uniqueArray[k] = array[i];
                }
            }

            return uniqueArray.Where(item => item > 0).ToArray();
        }
    }
}
