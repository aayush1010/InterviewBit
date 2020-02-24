using System;

namespace InterviewBit.Strings
{
    class Palindrome_String
    {
        private bool isAlphaNumeric(char c)
        {
            if ((c >= '0' && c <= '9') || (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
            {
                return true;
            }
            return false;
        }

        public int isPalindrome(string A)
        {
            int i = 0, j = A.Length - 1, r = 1;
            while (i <= j)
            {
                if (!isAlphaNumeric(A[i]))
                {
                    i++;
                    continue;
                }
                if (!isAlphaNumeric(A[j]))
                {
                    j--;
                    continue;
                }
                if (A[i] != A[j] && Math.Abs(A[i] - A[j]) != 32)
                {
                    return 0;
                }
                i++;
                j--;
            }
            return 1;
        }
    }
}
