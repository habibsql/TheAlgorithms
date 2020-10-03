using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TheAlgorithms.StringRelated.Repeating
{
    public class RepetitiveTests
    {
        private readonly Repetitive repetitive = new Repetitive();

        [Fact]
        public void ShoudReturnValidCharacterCount()
        {
            string word = "banglaba";
            Dictionary<string, int> countValues = repetitive.CountRepetitiveCharacters(word);

            Assert.Equal(2, countValues["b"]);
            Assert.Equal(3, countValues["a"]);
        }
    }
}
