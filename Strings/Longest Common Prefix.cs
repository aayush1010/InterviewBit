using System.Collections.Generic;
using System.Linq;

namespace InterviewBit.Strings
{
    class Longest_Common_Prefix
    {
        public string longestCommonPrefix(List<string> A)
        {
            int i = 0, k = 0;
            int minLength = A.Min(y => y.Length);
            string shortest = A.FirstOrDefault(x => x.Length == minLength);
            string s = string.Empty;
            while (i < shortest.Length)
            {
                var temp = A[0][i];
                for (int j = 1; j < A.Count; j++)
                {
                    if (A[j][i] != temp)
                    {
                        return s;
                    }
                }
                s += temp;
                i++;
            }
            return s;
        }
    }
}
