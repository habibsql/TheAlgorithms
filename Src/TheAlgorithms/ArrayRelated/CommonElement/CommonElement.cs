using System;
using System.Collections.Generic;
using System.Text;

namespace TheAlgorithms.ArrayRelated.CommonElement
{
    public class CommonElement
    {
        public int[] FindCommonElements(int[] firstArray, int[] secondArray, int[] thirdArray)
        {
            var commonList = new List<int>();

            for(int i=0; i < firstArray.Length; i ++)
            {
                for(int j =0; j < secondArray.Length; j++)
                {
                    if (firstArray[i] == secondArray[j])
                    {
                        for (int k = 0; k < thirdArray.Length; k++)
                        {
                            if (secondArray[j] == thirdArray[k])
                            {
                                commonList.Add(thirdArray[k]);
                            }
                        }
                    }
                }
            }

            return commonList.ToArray();
        }
    }
}
