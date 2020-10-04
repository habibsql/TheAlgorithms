using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TheAlgorithms.StringRelated.Palindrome
{
    public class PalindromeTest
    {
        private readonly Palindrome palindrome = new Palindrome();

        [Fact]
        public void PalendromERecursiveTest()
        {
            string input = "madam";
            bool yes = palindrome.IsPalendrome(input);
            Assert.True(yes);

            input = "abcd";
            yes = palindrome.IsPalendrome(input);
            Assert.False(yes);
        }

        [Fact]
        public void PalendromIterativeTest()
        {
            string input = "madam";
            bool yes = palindrome.IsPalendrome(input);
            Assert.True(yes);

            input = "abcd";
            yes = palindrome.IsPalendrome(input);
            Assert.False(yes);
        }
    }
}
