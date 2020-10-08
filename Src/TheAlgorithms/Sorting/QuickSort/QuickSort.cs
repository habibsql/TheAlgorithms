using System;
using System.Collections.Generic;
using System.Text;

namespace TheAlgorithms.ArrayRelated.QuickSort
{
    public class QuickSort
    {

        /// <summary>
        /// Sort an unsorted integer array using quicksort algorithm recursively
        /// </summary>
        /// <param name="array">unsorted array</param>
        /// <returns>sorted array</returns>
        public void SortRecursive(int[] array)
        {
            int lowerBound = 0;
            int upperBound = array.Length - 1;

            DoQuickSortRecursive(array, lowerBound, upperBound);
        }

        private void DoQuickSortRecursive(int[] array, int lowerBound, int upperBound)
        {
            if (lowerBound < upperBound)
            {
                int partitionIndex = DoPartition(array, lowerBound, upperBound);
                DoQuickSortRecursive(array, lowerBound, partitionIndex - 1);
                DoQuickSortRecursive(array, partitionIndex + 1, upperBound);
            }
        }

        private int DoPartition(int[] array, int lowerBound, int upperBound)
        {
            int pivot = array[lowerBound];
            int startIndex = lowerBound;
            int endIndex = upperBound;

            while (startIndex < endIndex)
            {
                while (array[startIndex] <= pivot && startIndex < endIndex)
                {
                    startIndex++;
                }

                while (array[endIndex] > pivot)
                {
                    endIndex--;
                }

                if (startIndex < endIndex)
                {
                    Swap(array, startIndex, endIndex);
                }
            }

            Swap(array, lowerBound, endIndex);

            return endIndex;

        }

        /// <summary>
        /// Sort unsorted array using quick sort with iteratively
        /// </summary>
        /// <param name="array"></param>
        public void SortIterative(int[] array)
        {
            var stack = new Stack<int>();
            stack.Push(array.Length - 1);
            stack.Push(0);            

            while (stack.Count > 0)
            {
                int lowIndex = stack.Pop();
                int heighIndex = stack.Pop();
              
                int pivotIndex = DoPartition(array, lowIndex, heighIndex);

                if (pivotIndex - 1 > lowIndex)
                {
                    stack.Push(pivotIndex - 1);
                    stack.Push(lowIndex);                   
                }
                if (pivotIndex + 1 < heighIndex)
                {
                    stack.Push(heighIndex);
                    stack.Push(pivotIndex + 1);                                
                }
            }
        }

        private int PartitionIterative(int[] array, int lowIndex, int highIndex)
        {
            int pivotValue = array[highIndex];
            int index = lowIndex - 1;

            for (int j = lowIndex; j <= highIndex - 1; j++)
            {
                if (array[j] <= pivotValue)
                {
                    index++;
                    Swap(array, index, j);
                }
            }

            index++;
            Swap(array, index, highIndex);

            return index;
        }

        private void Swap(int[] arrary, int startIndex, int endIndex)
        {
            int temp = arrary[startIndex];
            arrary[startIndex] = arrary[endIndex];
            arrary[endIndex] = temp;
        }
    }
}
