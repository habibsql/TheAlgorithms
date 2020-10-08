using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TheAlgorithms.ArrayRelated.LinearSearch
{
    public class LinearSearchTest
    {
        private readonly LinearSearch linearSearch = new LinearSearch();

        [Fact]
        public void ShouldReturnTrueWhenExitingKeyProvided()
        {
            var array = new int[] { 60, 20, 50, 10, 30 };
            var key = 10;

            bool exists = linearSearch.IsKeyExists(array, key);

            exists.Should().BeTrue();
        }

        [Fact]
        public void ShouldReturnFalseWhenNonExitingKeyProvided()
        {
            var array = new int[] { 60, 20, 50, 10, 30 };
            var key = 11;

            bool exists = linearSearch.IsKeyExists(array, key);

            exists.Should().BeFalse();
        }

    }
}
