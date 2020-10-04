using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TheAlgorithms.MathRelated.PrimeNumber
{
    public class PrimeNumberTest
    {
        private readonly PrimeNumber primeNumber = new PrimeNumber();

        [Fact]
        public void ShouldReturnPrimeNumbers()
        {
            List<int> primeNumbers = primeNumber.GeneratePrimeNumbers(0, 20);

            Assert.Equal(8, primeNumbers.Count);
        }

        [Fact]
        public void ShouldReturnPrimeNumbersOptimized()
        {
            List<int> primeNumbers = primeNumber.GeneratePrimeNumbersOptimized(0, 20);

            Assert.Equal(8, primeNumbers.Count);
        }
    }
}
