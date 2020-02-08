using System.Collections.Generic;

namespace InterviewBit.Arrays
{
    class Hotel_Bookings_Possible
    {
        public int hotel(List<int> arrive, List<int> depart, int K)
        {
            arrive.Sort();
            depart.Sort();
            int roomRequired = 1, i = 1, j = 0, n = arrive.Count, maxroom = 1;

            while (i < n && j < n)
            {
                if (arrive[i] < depart[j])
                {
                    i++;
                    roomRequired++;
                    if (roomRequired > maxroom)
                    {
                        maxroom = roomRequired;
                    }
                }
                else
                {
                    j++;
                    roomRequired--;
                }
            }

            return K >= maxroom ? 1 : 0;
        }
    }
}
