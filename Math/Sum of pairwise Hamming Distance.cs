using System.Collections.Generic;

namespace InterviewBit.Math
{
    class Sum_of_pairwise_Hamming_Distance
    {
        // consider the array as combinations of 0 and 1 only
        // the total sum is then 2*NUMBER OF ZEROS * NUMBER OF ONES
        // as only the combination of zero and one gives output as 1 
        // and each pair is considered twice thats why 2 is there.
        public int hammingDistance(List<int> A)
        {
            int total = 0;
            for (int i = 0; i < 32; i++)
            {
                int numberOfSetBits = 0;
                for (int j = 0; j < A.Count; j++)
                {
                    if ((A[j] & (1 << i)) != 0)
                    {
                        numberOfSetBits++;
                    }
                }

                total += (2 * ((numberOfSetBits % 1000000007) * ((A.Count - numberOfSetBits) % 1000000007)) % 1000000007) % 1000000007;
            }
            return total;
        }
    }
}
