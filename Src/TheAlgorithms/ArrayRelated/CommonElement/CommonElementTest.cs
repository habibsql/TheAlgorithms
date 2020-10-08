using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TheAlgorithms.ArrayRelated.CommonElement
{
    public class CommonElementTest
    {
        private readonly CommonElement commonElement = new CommonElement();

        [Fact]
        public void ShouldReturnCommonElement()
        {
            int[] inputArray1 = new int[] { 1, 5, 10, 20, 40, 80 };
            int[] inputArray2 = new int[] { 6, 7, 20, 80, 100 };
            int[] inputArray3 = new int[] { 3, 4, 15, 20, 30, 70, 80, 120 };
            int[] expectedCommonElements = new int[] { 20, 80 };

            int[] actualCommonElements = commonElement.FindCommonElements(inputArray1, inputArray2, inputArray3);

            actualCommonElements.Should().BeEquivalentTo(expectedCommonElements);
        }

    }
}
