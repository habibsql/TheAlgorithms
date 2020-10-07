using System;
using System.Collections.Generic;
using System.Text;

namespace TheAlgorithms.ArrayRelated.BinarySearch
{
    public class BinarySearch
    {
        /// <summary>
        /// Check a given value is exists in an array using binary search macanism.
        /// </summary>
        /// <param name="array">Sorted array of integer</param>
        /// <param name="key">That value needs to check existence</param>
        /// <returns>If found then true else false</returns>
        public bool IsKeyExists(int[] array, int key)
        {
            int minIndex = 0;
            int maxIndex = array.Length - 1;

            while (minIndex <= maxIndex)
            {
                int midIndex = (minIndex + maxIndex) / 2;
                
                if (key == array[midIndex])
                {
                    return true;
                }

                if (key < array[midIndex])
                {
                    maxIndex = midIndex - 1;
                }
                else
                {
                    minIndex = midIndex + 1;
                }
            }

            return false;
        }
    }
}
