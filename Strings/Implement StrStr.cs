namespace InterviewBit.Strings
{
    class Implement_StrStr
    {
        public int strStr(string A, string B)
        {
            int n = A.Length;
            int z = B.Length;
            if (n == 0 || z == 0)
            {
                return -1;
            }
            int i, j;
            for (i = 0; i < n; i++)
            {
                if (A[i] == B[0])
                {
                    j = 0;
                    while (j < z && j + i < n && A[j + i] == B[j])
                    {
                        j++; 
                    }
                    if (j == z)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
    }
}
