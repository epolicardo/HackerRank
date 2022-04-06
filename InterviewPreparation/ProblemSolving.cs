using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.InterviewPreparation
{
    public static class ProblemSolving
    {
        /*
        Given five positive integers, find the minimum and maximum values that can be calculated by summing 
       exactly four of the five integers. Then print the respective minimum and maximum values as a single
       line of two space-separated long integers.

       Example
           The minimum sum is  and the maximum sum is . The function prints
           16 24

        */
        public static string MiniMaxSum(List<int> arr)
        {

            long min = 0;
            long max = 0;

            arr.Sort();

            for (int i = 0; i < 4; i++)
                min = min + arr[i];

            for (int i = arr.Count; i > 1; i--)
                max = max + arr[i - 1];

            return $"{min} {max}";

        }

        public static int birthdayCakeCandles(List<int> candles)
        { 
            int max = candles.Max();
            return candles.Where(c => c == max).Count();
        }
    }
}
