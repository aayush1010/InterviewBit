using System.Collections.Generic;

namespace InterviewBit.Arrays
{
    class Flip
    {
        // Flip 0's to 1 and 1's to -1 and apply kadane's
        // as the max sum will tell the subarray with max 1's after flip
        public List<int> flip(string A)
        {
            int l = A.Length;
            List<int> toint = new List<int>();
            List<int> res = new List<int>();
            bool anyzero = false;
            for (int i = 0; i < l; i++)
            {
                if (A[i] == '0')
                {
                    anyzero = true;
                }
                if (A[i] == '0')
                {
                    toint.Add(1);
                }
                else
                {
                    toint.Add(-1);
                }
            }
            if (!anyzero)
            {
                return res;
            }
            int start = 0, end = l - 1, curstart = 0, curend = 0;
            int maxsum = 0, currsum = 0;
            for (int i = 0; i < l; i++)
            {
                if (currsum + toint[i] >= 0)
                {
                    currsum += toint[i];
                    curend = i;
                }
                else
                {
                    currsum = 0;
                    curstart = i + 1;
                }
                if (maxsum < currsum)
                {
                    maxsum = currsum;
                    start = curstart;
                    end = curend;
                }
            }
            res.Add(start + 1);
            res.Add(end + 1);
            return res;
        }
    }
}
