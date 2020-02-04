using System.Collections.Generic;

namespace InterviewBit.Arrays
{
    class Spiral_Order_Matrix_II
    {
        public List<List<int>> generateMatrix(int A)
        {
            List<List<int>> spiral = new List<List<int>>();
            int i, k = 0, l = 0, m = A, n = A, count = 1;

            while (k < m && l < n)
            {
                for (i = l; i < n; ++i)
                {
                    spiral[k][i] = count;
                    count++;
                }
                k++;

                for (i = k; i < m; ++i)
                {
                    spiral[i][n - 1] = count;
                    count++;
                }
                n--;

                if (k < m)
                {
                    for (i = n - 1; i >= l; --i)
                    {
                        spiral[m - 1][i] = count;
                        count++;
                    }
                    m--;
                }
                if (l < n)
                {
                    for (i = m - 1; i >= k; --i)
                    {
                        spiral[i][l] = count;
                        count++;
                    }
                    l++;
                }
            }
            return spiral;
        }
    }
}
