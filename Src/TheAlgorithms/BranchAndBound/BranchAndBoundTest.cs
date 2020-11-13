namespace TheAlgorithms.BranchAndBound
{
    using FluentAssertions;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Xunit;

    public class BranchAndBoundTest
    {
        private readonly BranchAndBound branchAndBound = new BranchAndBound();

        [Fact]
        public void Should_Return_Optimum_Value()
        {
            var val = new int[] { 60, 100, 120 };
            var wt = new int[] { 10, 20, 30 };
            const int W = 50;
            int n = val.Length;

            int optimumValue = branchAndBound.KnapSack(W, wt, val, n);

            optimumValue.Should().Be(220);
        }
    }
}
