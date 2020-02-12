using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewBit.Maths
{
    class Excel_Column_Title
    {
        public string convertToTitle(int A)
        {
            string s = string.Empty;
            while (A > 0)
            {
                if (A % 26 == 0)
                {
                    s += "Z";
                    A = A / 26 - 1;
                }
                else
                {
                    s += (char)(((A % 26) - 1) + 'A');
                    A /= 26;
                }
            }
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
