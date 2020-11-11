namespace TheAlgorithms.ArrayRelated.CostCalculation
{
    using FluentAssertions;
    using Xunit;

    public class CostCalculationTest
    {
        private readonly CostCalculation costCalculation = new CostCalculation();

        [Fact]
        public void Should_Calulate_Minimum_Cost()
        {
            var input = new int[4, 4];
            input[0, 0] = 2;
            input[0, 1] = 4;
            input[0, 2] = 3;
            input[0, 3] = 7;

            input[1, 0] = 6;
            input[1, 1] = 5;
            input[1, 2] = 1;
            input[1, 3] = 3;

            input[2, 0] = 9;
            input[2, 1] = 6;
            input[2, 2] = 2;
            input[2, 3] = 8;

            input[3, 0] = 1;
            input[3, 1] = 3;
            input[3, 2] = 4;
            input[3, 3] = 9;

            int minimumCost = costCalculation.CalculateMinimumCostForLastElement(input);

            minimumCost.Should().Be(18);
        }
    }
}
