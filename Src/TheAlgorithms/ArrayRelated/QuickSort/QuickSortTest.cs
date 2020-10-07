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
        public void ShouldSortArray()
        {
            int[] array = new int[] { 2, 5, 7, 9, 8, 3 };

            quickSort.Sort(array);

            array[0].Should().Be(2);
            array[3].Should().Be(7);
            array[5].Should().Be(9);
        }

    }
}
