namespace InterviewBit.Strings
{
    class Amazing_Subarrays
    {
        public int solve(string A)
        {
            int c = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 'A' || A[i] == 'E' || A[i] == 'I' || A[i] == 'O' || A[i] == 'U'
                || A[i] == 'a' || A[i] == 'e' || A[i] == 'i' || A[i] == 'o' || A[i] == 'u')
                {
                    c += (A.Length - i);
                }
            }
            return c % 10003;
        }
    }
}
