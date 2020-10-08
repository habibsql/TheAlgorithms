using System;
using System.Collections.Generic;
using System.Text;

namespace TheAlgorithms.ArrayRelated.LinearSearch
{
    public class LinearSearch
    {

        /// <summary>
        /// Search an item in a unsorted array with Linear search
        /// </summary>
        /// <param name="array">an integer array</param>
        /// <param name="key">the item to be searched</param>
        /// <returns>If found then true else false</returns>
        public bool IsKeyExists(int[] array, int key)
        {
            for(int index = 0; index < array.Length; index++)
            {
                if (key == array[index])
                {
                    return true;
                }
            }

            return false;
        }
    }
}
