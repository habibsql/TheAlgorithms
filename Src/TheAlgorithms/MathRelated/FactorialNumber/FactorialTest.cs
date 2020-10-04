using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TheAlgorithms.MathRelated.FactorialNumber
{
    public class FactorialTest
    {
        private readonly Factorial factorial = new Factorial();

        [Fact]
        public void ShouldReturnFactorialNumber()
        {
            int n = 5;
            int factNumber = factorial.GenerateFactorialNumber(n);

            Assert.Equal(120, factNumber);
        }

        [Fact]
        public void ShouldReturnFactorialNumberRecursive()
        {
            int n = 5;
            int factNumber = factorial.GenerateFactorialNumberRecursive(n);

            Assert.Equal(120, factNumber);
        }
    }
}
