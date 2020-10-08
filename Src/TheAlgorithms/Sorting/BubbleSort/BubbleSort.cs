using System;
using System.Collections.Generic;
using System.Text;

namespace TheAlgorithms.Sorting.BubbleSort
{
    public class BubbleSort
    {
        /// <summary>
        /// Sort a given unsorted array
        /// </summary>
        /// <param name="array">unsorted array</param>
        public void Sort(int[] array)
        {
            for(int i=0; i < array.Length - 1; i++)
            {
                for(int j=0; j < array.Length -i -1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(array, j+1, j);
                    }
                }
            }
        }

        private void Swap(int[] array, int firstIndex, int secondIndex)
        {
            int temp = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = temp;
        }

    }
}
