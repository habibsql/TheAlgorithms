using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TheAlgorithms.StringRelated.ContainsDigitOnly
{
    public class ContainDigitTest
    {
        private readonly ContainDigit containDigit = new ContainDigit();

        [Fact]
        public void ShouldReturnTrueWhenContainNumberInStringProvided()
        {
            string input = "123456";
          
            bool digitOnly = containDigit.IsContainOnlyDigit(input);

            Assert.True(digitOnly);
        }

        [Fact]
        public void ShouldReturnTrueWhenContainNumberInStringProvidedForVersion2()
        {
            string input = "123456";

            bool digitOnly = containDigit.IsContainOnlyDigitV2(input);

            Assert.True(digitOnly);          
        }


        [Fact]
        public void ShouldReturnFalseWhenContainAlphaNumericProvided()
        {
            string input = "abc123456";         

            bool digitOnly = containDigit.IsContainOnlyDigit(input);

            Assert.False(digitOnly);
        }

        [Fact]
        public void ShouldReturnFalseWhenContainAlphaNumericProvidedForVersion2()
        {
            string input = "abc123456";

            bool digitOnly = containDigit.IsContainOnlyDigitV2(input);

            Assert.False(digitOnly);
        }
    }
}
