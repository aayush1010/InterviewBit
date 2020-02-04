using System;
using System.Collections.Generic;

namespace InterviewBit.Arrays
{
    class Maximum_Absolute_Difference
    {
        public int maxArr(List<int> A)
        {
            int length = A.Count;
            int max1 = int.MinValue, max2 = int.MinValue, min1 = int.MaxValue, min2 = int.MaxValue;
            for (int i = 0; i < length; i++)
            {
                max1 = Math.Max(max1, A[i] + i);
                min1 = Math.Min(min1, A[i] + i);
                max2 = Math.Max(max2, A[i] - i);
                min2 = Math.Min(min2, A[i] - i);
            }
            return Math.Max(max1 - min1, max2 - min2);
        }
    }
}
