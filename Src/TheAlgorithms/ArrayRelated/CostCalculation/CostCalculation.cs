namespace TheAlgorithms.ArrayRelated.CostCalculation
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class CostCalculation
    {
        /// <summary>
        /// Calculate cost from first element
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int CalculateMinimumForLastElement(int[,] input)
        {
            int n = 4;
            int rightDownCost = 0;

            for (int row = 0; row < n; row++)
            {
                if (row == 0)
                {
                    for (int col = 0; col < n; col++)
                    {
                        rightDownCost += input[0, col];
                    }
                }
                else
                {
                    rightDownCost += input[row, 3];
                }
            }

            int downRightCost = 0;
            for (int col = 0; col < n; col++)
            {
                if (col == 0)
                {
                    for (int row = 0; row < n; row++)
                    {
                        downRightCost += input[row, 0];
                    }
                }
                else
                {
                    downRightCost += input[3, col];
                }
            }

            return rightDownCost < downRightCost ? rightDownCost : downRightCost;
        }
    }
}
