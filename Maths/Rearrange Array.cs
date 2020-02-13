namespace InterviewBit.Maths
{
    class Rearrange_Array
    {
        // First step: Increase all values  
        // by (arr[arr[i]] % n) * n 
        // Second Step: Divide all values by n 
        void rearrange(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                arr[i] += (arr[arr[i]] % n) * n;
            }

            for (int i = 0; i < n; i++)
            {
                arr[i] /= n;
            }
        }
    }
}
