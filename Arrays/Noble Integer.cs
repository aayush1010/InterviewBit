using System.Collections.Generic;
using System.Linq;

namespace InterviewBit.Arrays
{
    class Noble_Integer
    {
        public int solve(List<int> A)
        {
            A.Sort();
            if (A[A.Count - 1] == 0)
            {
                return 1;
            }
            for (int i = 0; i < A.Count - 1; i++)
            {
                if (A[i] == A[i + 1])
                {
                    continue;
                }
                if (A[i] == A.Count - i - 1)
                {
                    return 1;
                }
            }
            return -1;
        }
    }
}
