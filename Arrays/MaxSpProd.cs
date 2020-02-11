using System.Collections.Generic;

namespace InterviewBit.Arrays
{
    class MaxSpProd
    {
        public int maxSpecialProduct(List<int> A)
        {
            Stack<int> stack = new Stack<int>();
            int[] nxtGreaterElement = new int[A.Count];
            int[] previousGreaterElement = new int[A.Count];


            for (int i = A.Count - 1; i >= 0; i--)
            {
                while (stack.Count != 0 && stack.Peek() < A[i])
                {
                    stack.Pop();
                }
                nxtGreaterElement[i] = stack.Count == 0 ? 0 :i;
                stack.Push(A[i]);
            }

            stack = new Stack<int>();
            for (int i = 0; i < A.Count; i++)
            {
                while (stack.Count != 0 && stack.Peek() < A[i])
                {
                    stack.Pop();
                }
                previousGreaterElement[i] = stack.Count == 0 ? 0 : i;
                stack.Push(A[i]);
            }

            int max = int.MinValue;
            for (int i = 0; i < A.Count; i++)
            {
                max = Math.Max(max, ((previousGreaterElement[i] % 1000000007) * (nxtGreaterElement[i] % 1000000007)) % 1000000007);
            }

            return max;
        }
    }
}
