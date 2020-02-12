using System.Collections.Generic;

namespace InterviewBit.Maths
{
    class FizzBuzz
    {
        public List<string> fizzBuzz(int A)
        {
            List<string> res = new List<string>();
            for (int i = 1; i <= A; i++)
            {
                if (i % 15 == 0)
                {
                    res.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    res.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    res.Add("Buzz");
                }
                else
                {
                    res.Add(i.ToString());
                }
            }
            return res;
        }
    }
}
