using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewBit.Binary_Search
{
    class Matrix_Median
    {
        public int findMedian(List<List<int>> arrList)
        {

            var min = int.MaxValue;
            var max = int.MinValue;

            var r = arrList.Count;
            var c = arrList[0].Count;

            foreach (var t in arrList)
            {
                if (t[0] < min)
                {
                    min = t[0];
                }

                var m = t.Count - 1;

                if (t[m] > max)
                {
                    max = t[m];
                }
            }

            var desired = (r * c + 1) / 2;

            while (min < max)
            {
                var mid = min + (max - min) / 2;
                var place = 0;

                for (int i = 0; i < r; i++)
                {
                    var get = Array.BinarySearch(arrList[i].ToArray(), mid);

                    if (get < 0)
                    {
                        get = Math.Abs(get) - 1;
                    }
                    else
                    {
                        while (get < arrList[i].Count && arrList[i][get] == mid)
                        {
                            get++;
                        }
                    }

                    place = place + get;
                }

                if (place < desired)
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid;
                }
            }

            return min;
        }
    }
}
