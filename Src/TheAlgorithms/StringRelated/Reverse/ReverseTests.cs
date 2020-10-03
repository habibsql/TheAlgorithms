using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TheAlgorithms.StringRelated.Reverse
{
    public class ReverseTests
    {
        private readonly Reverse reverse = new Reverse();

        [Fact]
        public void ShouldReverseString()
        {
            string word = "amader";
            string reverseWord = reverse.ReverseString(word);

            Assert.Equal("redama", reverseWord);
        }
    }
}
