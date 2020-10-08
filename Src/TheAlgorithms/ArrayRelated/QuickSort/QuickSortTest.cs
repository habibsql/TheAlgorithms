using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TheAlgorithms.ArrayRelated.QuickSort
{
    public class QuickSortTest
    {
        private readonly QuickSort quickSort = new QuickSort();

        [Fact]
        public void ShouldSortArrayRecursively()
        {
            int[] array = new int[] { 2, 5, 7, 9, 8, 3 };

            quickSort.SortRecursive(array);

            array[0].Should().Be(2);
            array[3].Should().Be(7);
            array[5].Should().Be(9);
        }

        [Fact]
        public void ShouldSortArrayIteratively()
        {
            int[] array = new int[] { 2, 5, 7, 9, 8, 3 };

            quickSort.SortIterative(array);

            array[0].Should().Be(2);
            array[3].Should().Be(7);
            array[5].Should().Be(9);
        }
    }
}
