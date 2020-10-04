using System;
using System.Collections.Generic;
using System.Text;

namespace TheAlgorithms.MathRelated.PrimeNumber
{
    public class PrimeNumber
    {
        /// <summary>
        /// Ordinary algorithm
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public List<int> GeneratePrimeNumbers(int start, int end)
        {
            var primeList = new List<int>();

            for (int i = start; i <= end; i++)
            {
                if (i <= 1)
                    continue;

                var prime = true;

                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                        break;
                    }
                }

                if (i == 2 || prime)
                {
                    primeList.Add(i);
                }
            }

            return primeList;
        }

        /// <summary>
        /// optimized Sieve algorithm 
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public List<int> GeneratePrimeNumbersOptimized(int start, int end)
        {
            var primeList = new List<int>();

            for (int i = start; i <= end; i++)
            {
                primeList.Add(i);
            }

            int limit = (int)Math.Ceiling(Math.Sqrt(end));

            for (int i = 2; i <= limit; i++)
            {
                for (int j = i * i; j <= end; j += i)
                {
                    primeList[j] = -1;
                }
            }

            primeList.RemoveAll( item =>  item < 2);

            return primeList;
        }
    }
}
