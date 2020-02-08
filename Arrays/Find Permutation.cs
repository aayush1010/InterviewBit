using System.Collections.Generic;

namespace InterviewBit.Arrays
{
    class Find_Permutation
    {
        List<int> findPerm(string A, int B)
        {
            List<int> v = new List<int>();
            for (int i = 0; i < B; i++)
            {
                v.Add(i + 1);
            }

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 'D')
                {
                    int d = 0;
                    int j = i;
                    while (j < A.Length && A[j] == 'D')
                    {
                        d++;
                        j++;
                    }
                    v.Reverse(i, d + 1);
                    i = j;
                }
            }
            return v;
        }
    }
}
