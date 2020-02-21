using System.Collections.Generic;

namespace InterviewBit.Binary_Search
{
    class Rotated_Sorted_Array_Search
    {
        public int search(List<int> A, int B)
        {
            int low = 0, high = A.Count - 1;

            while (low <= high)
            {
                int mid = (high + low) / 2;
                if (A[mid] == B)
                {
                    return mid;
                }
                else if (A[mid] >= A[low])
                {
                    if (B >= A[low] && B <= A[mid])
                    {
                        high = mid - 1;
                    }
                    else
                    {
                        low = mid + 1;
                    }
                }
                else if (A[mid] <= B && A[high] >= B)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return -1;
        }
    }
}
