namespace TheAlgorithms.ArrayRelated.CostCalculation
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class CostCalculation
    {
        public int CalculateMinimumForLastElement(int[,] input)
        {
            int n = 4;
            var costList = new List<int>(1);

            for (int i = 0; i < n; i++)
            {
                int currentCost = 0;

                for (int j = 0; j < n; j++)
                {
                    currentCost += input[i, j];
                }
                int c = 3;
                for (int index = i + 1; index < n; index++)
                {
                    int val = input[index, c];
                    currentCost += val;
                }

                if (costList.Count == 0)
                {
                    costList.Add(currentCost);
                }
                else
                {
                    int previousCost = costList[0];

                    if (previousCost > currentCost)
                    {
                        costList[0] = currentCost;
                    }
                }
            }

            return costList[0];
        }
    }


}
