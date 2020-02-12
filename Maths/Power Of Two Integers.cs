using System;

namespace InterviewBit.Math
{
    class Power_Of_Two_Integers
    {
        public int isPower(int A)
        {
            if (A == 1)
            {
                return 1;
            }
            for (int i = 2; i * i <= A; i++)
            {
                double y = Math.Log(A) / Math.Log(i);
                if ((y - (int)y) < 0.00000001)
                {
                    return 1;
                }
            }
            return 0;
        }
    }
}
