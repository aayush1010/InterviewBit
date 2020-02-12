using System;
using System.Collections.Generic;

namespace InterviewBit.Arrays
{
    class Min_Steps_in_Infinite_Grid
    {
        // As distance from one cordinate to next of its coordinate
        // can be calculated just by the Max between the difference of 
        // x co-ordinate and y co-ordinate.
        // e.g. : (1,2) and (3,7) so the steps required are  Max((3-1), (7-2)) 
        // i.e 5
        public int coverPoints(List<int> A, List<int> B)
        {
            int len = A.Count;
            int result = 0;
            for (int i = 0; i < len - 1; i++)
            {
                result += Math.Max(Math.Abs(A[i + 1] - A[i]), Math.Abs(B[i + 1] - B[i]));
            }
            return result;
        }
    }
}
