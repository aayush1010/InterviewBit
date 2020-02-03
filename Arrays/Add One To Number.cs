using System.Collections.Generic;

namespace InterviewBit.Arrays
{
    class Add_One_To_Number
    {
        public List<int> plusOne(List<int> A)
        {
            List<int> list = new List<int>();
            int length = A.Count;
            int c = 1;
            int numberOfPrecedingZeros = 0;
            while (numberOfPrecedingZeros < length && A[numberOfPrecedingZeros] == 0)
            {
                numberOfPrecedingZeros++;
            }
            for (int i = length - 1; i >= numberOfPrecedingZeros; i--) 
            {
                int n = A[i] + c;
                c = n / 10;
                list.Add(n % 10);
            }
            while (c != 0) 
            {
                list.Add(c % 10);
                c /= 10;
            }
            list.Reverse();
            return list;
        }
    }
}
