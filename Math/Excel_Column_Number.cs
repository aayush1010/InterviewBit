namespace InterviewBit.Math
{
    class Excel_Column_Number
    {
        public int titleToNumber(string A)
        {
            int sum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sum *= 26;
                sum += (A[i] - 64);
            }
            return sum;
        }
    }
}
