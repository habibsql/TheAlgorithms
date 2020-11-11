namespace TheAlgorithms.Backtracking
{
    using FluentAssertions;
    using Xunit;

    public class BacktrackingTest
    {
        private readonly Backgracking backgracking = new Backgracking();

        [Fact]
        public void Should_Return_Correct_Path()
        {
           int[,] maze = { { 1, 0, 0, 0 }, 
                         { 1, 1, 0, 1 }, 
                         { 0, 1, 0, 0 }, 
                         { 1, 1, 1, 1 } };

            int N = maze.GetLength(0);

            int[, ] result = backgracking.SolveMaze(maze, N);

            result[0, 0].Should().Be(1);
            result[1, 0].Should().Be(1);
            result[1, 1].Should().Be(1);
            result[2, 1].Should().Be(1);
            result[3, 1].Should().Be(1);
            result[3, 2].Should().Be(1);
            result[3, 3].Should().Be(1);  
        }
}
}
