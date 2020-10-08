using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TheAlgorithms.ArrayRelated.DuplicateRemove
{
    public class DuplicateRemoveTest
    {
        private readonly DuplicateRemove duplicateRemove = new DuplicateRemove();

        [Fact]
        public void ShouldReturnUniqueItemsUsingSet()
        {
            int[] inputValues = new int[] { 1, 2, 1, 2, 3, 4, 5 };
            int[] expectedUniqueValues = new int[] { 1, 2, 3, 4, 5 };

            int[] actualUniqueValues = duplicateRemove.RemoveDuplicateItem(inputValues);

            actualUniqueValues.Should().BeEquivalentTo(actualUniqueValues);
        }

        [Fact]
        public void ShouldReturnUniqueItemsUsingBasicTechnique()
        {
            int[] inputValues = new int[] { 1, 2, 1, 2, 3, 4, 5 };
            int[] expectedUniqueValues = new int[] { 1, 2, 3, 4, 5 };

            int[] actualUniqueValues = duplicateRemove.RemoveDuplicateItemBasic(inputValues);

            actualUniqueValues.Should().BeEquivalentTo(actualUniqueValues);
        }

    }
}
