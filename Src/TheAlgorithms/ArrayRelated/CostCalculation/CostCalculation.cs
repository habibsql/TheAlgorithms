/*
The path to reach (m, n) must be through one of the 3 cells: (m-1, n-1) or (m-1, n) or (m, n-1). 
So minimum cost to reach (m, n) can be written as “minimum of the 3 cells plus cost[m][n]”.
minCost(m, n) = min (minCost(m-1, n-1), minCost(m-1, n), minCost(m, n-1)) + cost[m][n]
*/
namespace TheAlgorithms.ArrayRelated.CostCalculation
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class CostCalculation
    {
        /// <summary>
        /// Calculate cost from first element to last eleemnt
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int CalculateMinimumCostForLastElement(int[,] cost)
        {
            return MinimumCost(cost, 3, 3);
        }

        private int MinimumCost(int[,] cost, int rowIndex, int columnIndex)
        {
            if (columnIndex < 0 || rowIndex < 0)
            {
                return int.MaxValue;
            }
            if (rowIndex + columnIndex == 0)
            {
                return cost[0, 0];
            }

            return cost[rowIndex, columnIndex] +
                    Min(
                        MinimumCost(cost, rowIndex - 1, columnIndex - 1),
                        MinimumCost(cost, rowIndex - 1, columnIndex),
                        MinimumCost(cost, rowIndex, columnIndex - 1)
                    );
        }

        private int Min(int x, int y, int z)
        {
            int a = Math.Min(x, y);

            return Math.Min(a, z);
        }
    }
}
