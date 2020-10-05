using System;
using System.Collections.Generic;
using System.Text;

namespace TheAlgorithms.ArrayRelated.SumSeries
{
    public class SeriesSum
    {
        /// <summary>
        /// Calculate Sum with normal procedure. Time coplexity O(n)
        /// </summary>
        /// <param name="array"></param>
        /// <param name="sizeofArray"></param>
        /// <returns></returns>
        public int Sum(int[] array, int sizeofArray)
        {
            int sum = 0;

            for(int index = 0; index < sizeofArray; index++)
            {
                sum += array[index];
            }

            return sum;
        }

        /// <summary>
        /// Calculate Sum with series formula n * (n + 1stTerm) / 2 . Time coplexity O(1)
        /// </summary>
        /// <param name="array"></param>
        /// <param name="sizeofArray"></param>
        /// <returns></returns>
        public int SumByFormula(int[] array, int sizeofArray)
        {
            int firstTerm = array[0];
            int nthTerm = array[sizeofArray - 1];

            int sum = nthTerm * (nthTerm + firstTerm) / 2;

            return sum;
        }
    }
}
