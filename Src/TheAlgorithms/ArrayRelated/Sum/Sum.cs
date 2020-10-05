using System;
using System.Collections.Generic;
using System.Text;

namespace TheAlgorithms.ArrayRelated.Sum
{
    public class Sum
    {
        /// <summary>
        /// Check and match sum value from subarray of an array. Time complexity O(n^2)
        /// </summary>
        /// <param name="arr">input array of integer</param>
        /// <param name="n">Array size</param>
        /// <param name="subArraySum">Expected sun value</param>
        /// <returns>subarray list</returns>
        public List<List<int>> GetSubArrayPair(int[] arr, int n, int subArraySum)
        {
            var resultList = new List<List<int>>();

            for(int i=0; i < n-1; i++)
            {
                for(int j= i + 1; j < n; j ++)
                {
                    int innerSum = arr[i] + arr[j];

                    if (innerSum == subArraySum)
                    {
                        resultList.Add(new List<int> { arr[i], arr[j] });
                    }
                }
            }

            return resultList;
        }
    }
}
