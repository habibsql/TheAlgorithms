using System;
using System.Collections.Generic;
using System.Text;

namespace TheAlgorithms.MathRelated.FactorialNumber
{
    public class Factorial
    {
        /// <summary>
        /// Iterative way
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int GenerateFactorialNumber(int n)
        {
            int fact = 1;

           for(int i=1; i <=n; i++)
            {
                fact = fact  * i;
            }

            return fact;
        }

        public int GenerateFactorialNumberRecursive(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            return n * GenerateFactorialNumberRecursive(n - 1);
        }
    }
}
