namespace InterviewBit.Binary_Search
{
    class Square_Root_of_Integer
    {
        public int sqrt(int x)
        {
            if (x <= 1)
            {
                return x;
            }
            long mid = 0;
            int start = 0;
            int end = x / 2;
            long el = 0;
            while (start <= end)
            {
                mid = start + (end - start) / 2;
                el = mid * mid;
                if (el == x)
                    return (int)mid;
                else if (el > x)
                {
                    end = (int)(mid - 1);
                }
                else
                {
                    start = (int)(mid + 1);
                }
            }
            return start - 1;
        }
    }
}
