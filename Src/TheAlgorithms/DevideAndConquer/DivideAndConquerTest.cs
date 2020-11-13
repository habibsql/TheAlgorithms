namespace TheAlgorithms.DevideAndConquer
{
    using FluentAssertions;
    using Xunit;

    public class DivideAndConquerTest
    {
        private readonly DivideAndConquer divideAndConquer = new DivideAndConquer();

        [Fact]
        public void Should_Return_Close_Distince()
        {
            Point[] P = { new Point { X = 2, Y = 3 }, new Point { X = 12, Y = 30 }, new Point { X = 40, Y = 50 }, 
                new Point { X = 5, Y = 1 }, new Point { X = 12, Y = 10 }, new Point { X = 3, Y = 4 } };

            int n = P.Length;

            double closedDistance = divideAndConquer.Closest(P, n);

            closedDistance.Should().Be(1.4142135623730951);
        }
    }
}
