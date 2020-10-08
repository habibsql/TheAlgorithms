using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;

namespace TheAlgorithms.ArrayRelated.BinarySearch
{
    public class BinarySearchTest
    {
        private readonly BinarySearch binarySearch = new BinarySearch();

        [Fact]
        public void ShouldReturnTrueWhenValidKeyProvided()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 8, 10, 12, 15 };
            int key = 8;

            bool found = binarySearch.IsKeyExists(arr, key);

            found.Should().BeTrue();
        }

        [Fact]
        public void ShouldReturnFalseWhenInValidKeyProvided()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 8, 10, 12, 15 };
            int key = 16;

            bool found = binarySearch.IsKeyExists(arr, key);

            found.Should().BeFalse();
        }

    }
}
