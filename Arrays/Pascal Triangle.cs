using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewBit.Arrays
{
    class Pascal_Triangle
    {
        public List<List<int>> solve(int A)
        {
            List<List<int>> listOuter = new List<List<int>>();
            int line = 1;
            for (int i = 1; i <= A; i++)
            {
                List<int> listInner = new List<int>();
                for(int j = 1; j <= i; j++) 
                {
                    if (j == 1 || j == i)
                    {
                        listInner.Add(1);
                    }
                    else 
                    {
                        listInner.Add((listOuter[i - 2])[j-1] + (listOuter[i - 2])[j - 2]);
                    }
                }
                listOuter.Add(listInner);
            }
            return listOuter;
        }

    }
}
