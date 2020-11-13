namespace TheAlgorithms.BranchAndBound
{
    using System;

    public class BranchAndBound
    {
        /// <summary>
        /// KanpSack0/1 problem
        /// </summary>
        /// <param name="W"></param>
        /// <param name="wt"></param>
        /// <param name="val"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public int KnapSack(int W, int[] wt, int[] val, int n)
        {
            // base condition
            if (n == 0 || W == 0)
                return 0;

            // if weight of the nth item is more than knapsack capacity W then this item
            // can not be included in the optimal solution.
            if (wt[n - 1] > W)
                return KnapSack(W, wt, val, n - 1);

            int temp = KnapSack(W - wt[n - 1], wt, val, n - 1);
            int val1 = val[n - 1] + temp;
            int val2 = KnapSack(W, wt, val, n - 1);

            return Math.Max(val1, val2);
        }
    }
}
