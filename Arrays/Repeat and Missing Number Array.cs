using System.Collections.Generic;

namespace InterviewBit.Arrays
{
    class Repeat_and_Missing_Number_Array
    {
        // Let two numbers are a, b
        // sumactual = sumCurrent + a- b
        // sumsquareactual = sumsquarecurrent + a^2 - b^2
        // using 2 equation find two numbers
        public List<int> repeatedNumber(List<int> A)
        {
            List<int> list = new List<int>();
            int length = A.Count;
            long sumActual = (length * (1 + length)) / 2;
            long sumActualSquare = ((length) * (length + 1) * (2 * length + 1)) / 6;
            long sum = 0, sumSquare = 0;
            foreach (var item in A) 
            {
                sum += item;
                sumSquare += (item * item);
            }

            long sumDifference = sumActual - sum;
            long sumSqureDifference = sumActualSquare - sumSquare;

            int secondNumber = (int)((sumSqureDifference / sumDifference) + sumDifference) / 2;
            int firstNumber = (int)(secondNumber - sumDifference);
            list.Add(firstNumber);
            list.Add(secondNumber);
            return list;
        }
    }
}
