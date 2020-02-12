using System.Collections.Generic;

namespace InterviewBit.Maths
{
    class PrimeSum
    {
        public List<int> primesum(int A)
        {
            bool[] lisOfPrimesLessThanA = GetPrimes(A);

            List<int> list = new List<int>();
            for (int i = 2; i < A; i++)
            {
                if (lisOfPrimesLessThanA[i] && lisOfPrimesLessThanA[A - i])
                {
                    list.Add(i);
                    list.Add(A - i);
                    break;
                }
            }
            return list;
        }

        private bool[] GetPrimes(int a)
        {
            bool[] isPrime = new bool[a + 1];
            for (int i = 2; i <= a; i++)
            {
                isPrime[i] = true;
            }
            for (int i = 2; i * i <= a; i++)
            {
                if (isPrime[i])
                {
                    for (int j = i * i; j <= a; j += i)
                    {
                        isPrime[j] = false;
                    }
                }
            }

            return isPrime;
        }
    }
}
