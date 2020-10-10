using System;
using System.Collections.Generic;
using System.Text;

namespace TheAlgorithms.MathRelated.IntegerReverse
{
    public class IntegerReverse
    {
        public int DoReverse(int theNumber)
        {
            int leftNumber = theNumber;
            int reverseNumber  = 0;

           while(leftNumber != 0)
            {
                int remender = leftNumber % 10;

                reverseNumber = reverseNumber * 10 + remender;

                leftNumber /= 10;
            }

            return reverseNumber;
        }

    }
}
