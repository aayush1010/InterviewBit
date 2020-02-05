using System;
using System.Collections.Generic;

namespace InterviewBit.Arrays
{
    class Find_Duplicate_in_Array
    {
        // mark visited number with negative of itself
        public int repeatedNumber(List<int> a)
        {
            for (int i = 0; i < a.Count; i++)
            {
                if (a[Math.Abs(a[i])] > 0)
                {
                    a[Math.Abs(a[i])] = -1 * a[Math.Abs(a[i])];
                }
                else
                {
                    return Math.Abs(a[i]);
                }
            }
            return -1;
        }
    }
}
