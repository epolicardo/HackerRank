using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.InterviewPreparation
{
    public class OneWeekPreparationKit
    {
        /// <summary>
        /// Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero. Print the decimal value of each fraction on a new line with places after the decimal.
        /// Note: This challenge introduces precision problems.The test cases are scaled to six decimal places, though answers with absolute error of up to are acceptable.
        /// </summary>
        /// <param name="arr"></param>

        public static Func<List<int>, int> positive = list => list.Where(x => x > 0).Count();
        public static Func<List<int>, int> zero = List => List.Where(x => x == 0).Count();
        public static Func<List<int>, int> negative = list => list.Where(x => x < 0).Count();

        public static void plusMinus(List<int> arr)
        {
            Console.WriteLine(((float)positive(arr) / arr.Count).ToString("0.000000"));
            Console.WriteLine(((float)negative(arr) / arr.Count).ToString("0.000000"));
            Console.WriteLine(((float)zero(arr) / arr.Count).ToString("0.000000"));
        }

        public static int findMedian(List<int> arr)
        {
            arr.Sort();
            int medio = arr.Count() / 2;

            return arr.IndexOf(medio);
        }

        /// <summary>
        /// Given a time in -hour AM/PM format, convert it to military (24-hour) time.
        /// Note: - 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
        /// - 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string timeConversion(string s)
        {
            var splited = s.Split(":");
            var mitad = splited[2].Substring(2, 2);
            string hora = string.Empty;

            switch (mitad)
            {
                case "AM":
                    {
                        if (splited[0] == "12")
                        {
                            hora = (12 - Convert.ToInt32(splited[0])).ToString("00");
                        }
                        else
                        {
                            hora = splited[0];
                        }
                    }
                    break;

                case "PM":
                    {
                        if (splited[0] != "12")
                        {
                            hora = (24 - (12 - Convert.ToInt32(splited[0]))).ToString();
                        }
                        else
                        {
                            hora = splited[0];
                        }
                    }
                    break;

                default:
                    break;
            }

            return $"{hora}:{splited[1]}:{splited[2].Substring(0, 2)}";
        }
    }
}