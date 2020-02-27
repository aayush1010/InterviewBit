using InterviewBit.Arrays;
using InterviewBit.Maths;
using InterviewBit.Strings;
using System.Collections.Generic;

namespace InterviewBit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Max_Non_Negative_SubArray m = new Max_Non_Negative_SubArray();
            //m.maxset(new List<int> { 0, 0, -1, 0 });
            //Spiral_Order_Matrix_II sp = new Spiral_Order_Matrix_II();
            //var a = sp.generateMatrix(80);
            //Pascal_Triangle p = new Pascal_Triangle();
            //p.solve(4);

            //MaxSpProd mp = new MaxSpProd();
            //mp.maxSpecialProduct(new List<int> { 5, 9, 6, 8, 6, 4, 6, 9, 5, 4, 9 });

            //Next_Permutation nx = new Next_Permutation();
            //nx.nextPermutation(new List<int> { 5, 3, 4, 9, 7, 6 });

            //Sorted_Permutation_Rank s = new Sorted_Permutation_Rank();
            //s.findRank("string");

            Minimum_Char_for_Palindromic_string m = new Minimum_Char_for_Palindromic_string();
            m.solve("banana");
        }
    }
}
