/*
Findout total number of ways reach to cell in a matrix
*/
namespace TheAlgorithms.DynamicProgramming
{
    public class DynamicProgramming
    {
        public int CalculateTotalWaysToReachInLastCell(int[,] matrix, int N)
        {
            int[,] localMatrix = new int[4, 4];

            for (int i = 0; i < N; i++)
            {
                localMatrix[0, i] = 1;
                localMatrix[i, 0] = 1;
            }

            for (int i = 1; i < N; i++)
            {
                for (int j = 1; j < N; j++)
                {
                    localMatrix[i, j] = localMatrix[i - 1, j] + localMatrix[i, j - 1];
                }
            }

            return localMatrix[N - 1, N - 1];
        }

        public int CalculateMinimumCostToReachInLastCell(int[,] matrix, int N)
        {
            int[,] localMatrix = new int[4, 4];

            for (int i = 0; i < N; i++)
            {
                localMatrix[0, i] = 1;
                localMatrix[i, 0] = 1;
            }

            for (int i = 1; i < N; i++)
            {
                for (int j = 1; j < N; j++)
                {
                    localMatrix[i, j] = localMatrix[i - 1, j] + localMatrix[i, j - 1];
                }
            }

            return localMatrix[N - 1, N - 1];
        }
    }
}
