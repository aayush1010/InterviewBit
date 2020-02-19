using System.Collections.Generic;

namespace InterviewBit.Binary_Search
{
    class SearchForRange
    {
        private int findFirst(List<int> A, int low, int high, int x, int n)
        {
            if (high >= low)
            {
                int mid = low + (high - low) / 2;
                if ((mid == 0 || x > A[mid - 1]) && A[mid] == x)
                {
                    return mid;
                }
                else if (x > A[mid])
                {
                    return findFirst(A, (mid + 1), high, x, n);
                }
                else
                {
                    return findFirst(A, low, (mid - 1), x, n);
                }
            }
            return -1;
        }

        private int findLast(List<int> A, int low,
                            int high, int x, int n)
        {
            if (high >= low)
            {
                int mid = low + (high - low) / 2;

                if ((mid == n - 1 || x < A[mid + 1]) && A[mid] == x)
                {
                    return mid;
                }
                else if (x < A[mid])
                {
                    return findLast(A, low, (mid - 1), x, n);
                }
                else
                {
                    return findLast(A, (mid + 1), high, x, n);
                }
            }

            return -1;
        }

        public List<int> searchRange(List<int> A, int B)
        {
            List<int> l = new List<int>();
            l.Add(findFirst(A, 0, A.Count, B, A.Count));
            l.Add(findLast(A, 0, A.Count, B, A.Count));
            return l;
        }
    }
}
