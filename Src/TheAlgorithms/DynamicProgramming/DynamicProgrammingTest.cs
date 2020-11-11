namespace TheAlgorithms.DynamicProgramming
{
    using FluentAssertions;
    using Xunit;

    public class DynamicProgrammingTest
    {
        private readonly DynamicProgramming dynamicProgramming = new DynamicProgramming();

        [Fact]
        public void Should_Return_All_Reachable_Path()
        {
            int[,] input = new int[4,4]
            {
                {10, 20, 30, 40 },
                {50, 60, 70, 80 },
                { 90, 100, 110, 120},
                {130, 140, 150, 160 }
            };

            int possiblePaths = dynamicProgramming.CalculateTotalWaysToReachInLastCell(input, 4);

            possiblePaths.Should().Be(20);
        }
    }
}
