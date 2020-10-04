using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Linq;

namespace TheAlgorithms.StringRelated.Permutation
{
    public class PermutationTest
    {
        private readonly Permutation permutation = new Permutation();

        [Fact]
        public void ShouldMakePermutationString()
        {
            string input = "123";
            var permutationList = new List<string>();

            permutation.DoPermutation(string.Empty, input, permutationList);

            Assert.Equal(6, permutationList.Count);
            Assert.Contains("123", permutationList);
            Assert.Contains("132", permutationList);
            Assert.Contains("213", permutationList);
            Assert.Contains("231", permutationList);
            Assert.Contains("321", permutationList);
            Assert.Contains("312", permutationList);
        }
    }
}
