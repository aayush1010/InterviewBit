using System.Collections.Generic;

namespace InterviewBit.Arrays
{
    class Max_Distance
    {
        //Take two arrays 
        //- one with leftmin
        //- other with rightmax
        // Now calculate the max gap for each leftmin to rightmax
        public int maximumGap(List<int> A)
        {
            int n = A.Count;
            int[] lmin = new int[n];
            int[] rmax = new int[n];
            lmin[0] = A[0];
            for (int i = 1; i < n; i++)
            {
                lmin[i] = Math.Min(lmin[i - 1], A[i]);
            }
            rmax[n - 1] = A[n - 1];
            for (int i = n - 2; i >= 0; i--)
            {
                rmax[i] = Math.Max(rmax[i + 1], A[i]);
            }
            int l = 0, m = 0, maxgap = -1;
            while (l < n && m < n)
            {
                if (lmin[l] <= rmax[m])
                {
                    maxgap = Math.Max(maxgap, m - l);
                    m++;
                }
                else
                {
                    l++;
                }
            }
            return maxgap;
        }
    }
}
