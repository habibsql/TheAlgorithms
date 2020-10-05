using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TheAlgorithms.ArrayRelated.SumSeries
{
    public class SeriesSumTest
    {
        private readonly SeriesSum seriesSum = new SeriesSum();

        [Fact]
        public void ShouldSumAllArrayElementsWhenNormalWay()
        {
            var array = new int[] {1, 2, 3, 4, 5};

            int sum = seriesSum.Sum(array, 5);

            Assert.Equal(15, sum);
        }

        [Fact]
        public void ShouldSumAllArrayElementsWhenUsingMathFormula()
        {
            var array = new int[] {1,  2, 3, 4, 5 };

            int sum = seriesSum.SumByFormula(array, 5);

            Assert.Equal(15, sum);
        }
    }
}
