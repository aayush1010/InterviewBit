using System.Collections.Generic;

namespace InterviewBit.Arrays
{
    class Max_Sum_Contiguous_Subarray
    {
        // Kadane's Algorithm
        public int maxSubArray(List<int> A)
        {
            int sum = A[0], currentSum = 0;
            int length = A.Count;
            for (int i = 0; i < length; i++) 
            {
                currentSum += A[i];
                sum = Math.Max(sum, currentSum);
                if (currentSum < 0) 
                {
                    currentSum = 0;
                }
            }
            return sum;
        }
    }
}
