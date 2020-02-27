using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewBit.Strings
{
    class Minimum_Char_for_Palindromic_string
    {
        static bool ispalindrome(String s)
        {
            int l = s.Length;

            for (int i = 0, j = l - 1; i <= j; i++, j--)
            {
                if (s[i] != s[j])
                {
                    return false;
                }
            }
            return true;
        }

        public int solve(string s)
        {
            int cnt = 0;
            int flag = 0;
            while (s.Length > 0)
            {
                if (ispalindrome(s))
                {
                    flag = 1;
                    break;
                }
                else
                {
                    cnt++;
                    s = s.Substring(0, s.Length - 1);
                }
            }
            return cnt;
        }
    }
}
