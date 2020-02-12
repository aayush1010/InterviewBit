using System.Collections.Generic;

namespace InterviewBit.Arrays
{
    class Maximum_Absolute_Difference
    {
        // |a[i] - a[j]| + |i-j| can be written in the form of
        // 1. a[i] - a[j] + i - j => (a[i] + i) - (a[j] + j)
        // 2. a[i] - a[j] - i + j => (a[i] - i) - (a[j] - j)
        // so for the max difference, (a[i] + i) should be max 
        // and (a[j] + j) should be min, or (a[i] - i) should be max
        // and (a[j] - j) should be min
        public int maxArr(List<int> A)
        {
            int length = A.Count;
            int max1 = int.MinValue, max2 = int.MinValue, min1 = int.MaxValue, min2 = int.MaxValue;
            for (int i = 0; i < length; i++)
            {
                max1 = Maths.Max(max1, A[i] + i);
                min1 = Maths.Min(min1, A[i] + i);
                max2 = Maths.Max(max2, A[i] - i);
                min2 = Maths.Min(min2, A[i] - i);
            }
            return Maths.Max(max1 - min1, max2 - min2);
        }
    }
}
