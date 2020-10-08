using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TheAlgorithms.Sorting.BubbleSort
{
    public class BubbleSortTest
    {
        private readonly BubbleSort bubbleSort = new BubbleSort();

        [Fact]
        public void ShouldSortWhenUnsortedArrayProvided()
        {
            int[] array = new int[] { 2, 5, 7, 9, 8, 3 };
            int[] expectedAfterSorted = new int[] { 2, 3, 5, 7, 8, 9 };

            bubbleSort.Sort(array);

            array.Should().BeEquivalentTo(expectedAfterSorted);
        }
    }
}
