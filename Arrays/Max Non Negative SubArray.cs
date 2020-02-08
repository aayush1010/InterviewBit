using System.Collections.Generic;

namespace InterviewBit.Arrays
{
    class Max_Non_Negative_SubArray
    {
        public List<int> maxset(List<int> A)
        {
            long maxsum = 0, cursum, currentNumberIncludedCount, numberIncludedCount = 0;
            int i = 0, j = 0, l = 0, r = 0;
            long size = A.Count;
            while (i < size)
            {
                currentNumberIncludedCount = 0;
                cursum = 0;
                while (j < size && A[j] >= 0)
                {
                    cursum += A[j];
                    j++;
                    currentNumberIncludedCount++;
                }
                if (cursum > maxsum)
                {
                    l = i;
                    r = j;
                    maxsum = cursum;
                    numberIncludedCount = currentNumberIncludedCount;
                }
                else if (cursum == maxsum)
                {
                    if (currentNumberIncludedCount > numberIncludedCount)
                    {
                        l = i;
                        r = j;
                        numberIncludedCount = currentNumberIncludedCount;
                    }
                }
                while (j < size && A[j] < 0)
                {
                    j++;
                }
                i = j;
            }
            List<int> list = new List<int>();
            for (int k = l; k < r; k++)
            {
                list.Add(A[k]);
            }
            return list;
        }
    }
}
