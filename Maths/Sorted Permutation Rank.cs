using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewBit.Maths
{
    class Sorted_Permutation_Rank
    {
        private int AlphaSmallers(bool[] present, bool[] covered, int s)
        {
            int c = 0;
            for (int i = 0; i < s; i++)
            {
                if (present[i] && covered[i])
                {
                    c++;
                }
            }
            return c;
        }

        private int fact(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return (n % 1000003) * fact(n - 1);
        }

        public int findRank(string A)
        {
            A = A.ToLower();
            bool[] present = new bool[26];
            bool[] covered = new bool[26];
            for (int i = 0; i < A.Length; i++)
            {
                present[A[i] - 'a'] = true;
                covered[A[i] - 'a'] = true;
            }

            int total = 1;
            for (int i = 0; i < A.Length; i++)
            {
                covered[A[i] - 'a'] = false;
                int smaller = AlphaSmallers(present, covered, A[i] - 'a');
                smaller = A.Length - i - 1 < smaller ? A.Length - i - 1 : smaller;

                total = ((total % 1000003) + (smaller * (fact(A.Length - i - 1)) % 1000003) % 1000003) % 1000003;

            }
            return total % 1000003;
        }
    }
}
