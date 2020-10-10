using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xunit;

namespace TheAlgorithms.MathRelated.IntegerReverse
{
    public class IntegerReverseTest
    {
        private readonly IntegerReverse reverse = new IntegerReverse();

        [Fact]
        public void ShouldReturnReverseNumber()
        {
            int result1 = reverse.DoReverse(987);
            int result2 = reverse.DoReverse(12345);
            int result3 = reverse.DoReverse(11);            
            
            result1.Should().Be(789);           
            result2.Should().Be(54321);
            result3.Should().Be(11);
        }
    }
}
