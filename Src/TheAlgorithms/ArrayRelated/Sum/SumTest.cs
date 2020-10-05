using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Linq;

namespace TheAlgorithms.ArrayRelated.Sum
{
    public class SumTest
    {
        private readonly Sum sum = new Sum();

        [Fact]
        public void ShouldReturnSubarrayWhenMatchWithSum()
        {
            int[] array = new int[] { 20, -10, 30, -10, 10, -20, 50, 30 };
            int arraySize = array.Length;
            int subArraySum = 20;

            List<List<int>> subArrayPair = sum.GetSubArrayPair(array, arraySize, subArraySum);

            Assert.Equal(4, subArrayPair.Count);
            Assert.Equal(20, subArrayPair[0][0] + subArrayPair[0][1]);
            Assert.Equal(20, subArrayPair[1][0] + subArrayPair[1][1]);
            Assert.Equal(20, subArrayPair[2][0] + subArrayPair[2][1]);
            Assert.Equal(20, subArrayPair[3][0] + subArrayPair[3][1]);
        }

    }
}
