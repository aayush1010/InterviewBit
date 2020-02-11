using System.Collections.Generic;

namespace InterviewBit.Arrays
{
    // Divide the array as in buckets that each bucket ranges as the gap
    // gap is calculates as (MAX-MIN)/n-1,
    // now for each bucket calculate the max of the bucket and min of the bucket 
    // and find the difference with current butcket's min and previous bucket max
    class MaximumConsecutiveGap
    {
        public int maximumGap(List<int> A)
        {
            int min = int.MaxValue;
            int max = int.MinValue;

            foreach (int i in A)
            {
                min = Math.Min(min, i);
                max = Math.Max(max, i);
            }
            if (A.Count <= 1 || (max == min))
            {
                return 0;
            }
            int gap = (int)Math.Ceiling((double)(max - min) / (A.Count - 1));
            List<int> mins = new List<int>();
            List<int> maxs = new List<int>();
            List<int> count = new List<int>();
            int bucketCount = A.Count;
            for (int i = 0; i < bucketCount; i++)
            {
                mins.Add(int.MaxValue);
                maxs.Add(int.MinValue);
                count.Add(0);
            }
            foreach (int n in A)
            {
                int bucket = (n - min) / gap;
                mins[bucket] = Math.Min(mins[bucket], n);
                maxs[bucket] = Math.Max(maxs[bucket], n);
                count[bucket]++;
            }
            int lastSeen = maxs[0];
            int result = lastSeen;
            for (int i = 1; i < bucketCount; i++)
            {
                if (count[i] > 0)
                {
                    result = Math.Max(result, mins[i] - lastSeen);
                    lastSeen = maxs[i];
                }
            }
            return result;
        }
    }
}
