using System;
using System.Collections.Generic;
using System.Text;

namespace TheAlgorithms.ArrayRelated.QuickSort
{
    public class QuickSort
    {

        /// <summary>
        /// Sort an unsorted integer array using quicksort algorithm 
        /// </summary>
        /// <param name="array">unsorted array</param>
        /// <returns>sorted array</returns>
        public void Sort(int[] array)
        {
            int lowIndex = 0;
            int heighIndex = array.Length - 1;

            DoQuickSort(array, lowIndex, heighIndex);
        }


        private void DoQuickSort(int[] array, int lowIndex, int heightIndex)
        {
            if (lowIndex < heightIndex)
            {
                int partitionIndex = DoPartition(array, lowIndex, heightIndex);

                DoQuickSort(array, lowIndex, partitionIndex - 1);
                DoQuickSort(array, partitionIndex + 1, heightIndex);
            }
        }


        private int DoPartition(int[] array, int lowIndex, int heighIndex)
        {
            int pivot = array[heighIndex];
            int index = lowIndex - 1;

            for (int j = lowIndex; j < heighIndex; j++)
            {
                if (array[j] < pivot)
                {
                    index++;
                    int temp1 = array[index];
                    array[index] = array[j];
                    array[j] = temp1;
                }
            }

            int temp2 = array[index + 1];
            array[index + 1] = array[heighIndex];
            array[heighIndex] = temp2;

            return index + 1;
        }
    }
}
