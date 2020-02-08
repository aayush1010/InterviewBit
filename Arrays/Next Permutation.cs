using System.Collections.Generic;

namespace InterviewBit.Arrays
{
    class Next_Permutation
    {
        // try to thnik from right side of array
        public List<int> nextPermutation(List<int> A)
        {
            int lastNum = 0;
            for (int i = A.Count - 1; i > 0; i--)
            {
                if (A[i] > A[i - 1])
                {
                    lastNum = i;
                    break;
                }
            }

            if (lastNum == 0)
            {
                A.Sort();
                return A;
            }

            int smallestNumGreaterThanLast = A[lastNum - 1];
            int smallest = lastNum;
            for (int i = lastNum + 1; i < A.Count; i++)
            {
                if (smallestNumGreaterThanLast < A[i] && A[i] < A[smallest])
                {
                    smallest = i;
                }
            }
            int t = A[smallest];
            A[smallest] = A[lastNum - 1];
            A[lastNum - 1] = t;

            A.Sort(lastNum, A.Count - lastNum,  null);

            return A;

        }
    }
}
