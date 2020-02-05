using System;
using System.Collections.Generic;

namespace InterviewBit.Arrays
{
    class Triplets_with_Sum_between_given_range
    {
        public int solve(List<string> s)
        {
            int n = s.Count;
            decimal a = Convert.ToDecimal(s[0]);
            decimal b = Convert.ToDecimal(s[1]);
            decimal c = Convert.ToDecimal(s[2]);
            for (int i = 3; i < n; i++)
            {
                if ((a + b + c) > 1 && (a + b + c) < 2)
                {
                    return 1;
                }
                else if ((a + b + c) >= 2)
                {
                    if (a > b && a > c)
                    {
                        a = Convert.ToDecimal(s[i]);
                    }
                    else if (b > c)
                    {
                        b = Convert.ToDecimal(s[i]);
                    }
                    else
                    {
                        c = Convert.ToDecimal(s[i]);
                    }
                }
                else
                {
                    if (a < b && a < c)
                    {
                        a = Convert.ToDecimal(s[i]);
                    }
                    else if (b < c)
                    {
                        b = Convert.ToDecimal(s[i]);
                    }
                    else
                    {
                        c = Convert.ToDecimal(s[i]);
                    }
                }
            }
            if ((a + b + c) > 1 && (a + b + c) < 2)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
