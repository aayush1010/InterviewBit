using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewBit.Arrays
{
    class First_Missing_Integer
    {
        public int firstMissingPositive(List<int> A)
        {
            int count = A.Count;
            bool[] present = new bool[count+1];
            for (int i = 0; i < count; i++) 
            {
                if (A[i] > 0 && A[i] <= count) 
                {
                    present[A[i]] = true;
                }
            }

            for (int i = 1; i < present.Length; i++) 
            {
                if (!present[i]) 
                {
                    return i;
                }
            }

            return count + 1;
        }
    }
}
