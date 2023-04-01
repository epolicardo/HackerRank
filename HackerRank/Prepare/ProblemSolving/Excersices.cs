namespace HackerRank.Prepare.ProblemSolving
{
    public static class Excersices
    {
        /*

        */

        /// <summary>
        /// Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers.
        /// Then print the respective minimum and maximum values as a single line of two space-separated long integers.
        /// Example: The minimum sum is and the maximum sum is. The function prints 16 24
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
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

        public static List<int> GradingStudents(List<int> grades)
        {
            List<int> students = new List<int>();
            int diferencia = 0;
            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] < 38)
                {
                    students.Add(grades[i]);
                    continue;
                }
                else
                {
                    int resto = grades[i] % 5; //32
                    if (resto == 0)
                    {
                        students.Add(grades[i]);
                        continue;
                    }
                    else
                    {
                        diferencia = 5 - resto; //35
                    }
                    if (diferencia < 3)
                    {
                        students.Add(grades[i] + diferencia);
                    }
                    else
                    {
                        students.Add(grades[i]);
                    }
                }
            }
            return students;
        }

        /// <summary>
        /// Given two non - empty arrays of integers, write a function that determines whether the second array
        /// is a subsequence of the first one.
        /// A subsequence of an array is a set of numbers that aren't necessarily
        /// adjacent in the array but that are in the same order as they appear in the array.
        /// For instance, the numbers [1,3,4] form a subsequence of the array [1,2,3,4], and so do the numbers [2,4].
        /// Note that a single number in an array and the array itself are both valid subsequences of the array.
        /// Sample Input
        /// Array = [5, 1, 22, 25, 6, -1, 8, 10]
        /// Sequence = [1, 6, -1, 10]
        /// Sample Output: true
        /// </summary>
        /// <param name="array">First array to compare</param>
        /// <param name="sequence">Second array.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static bool SubsequenceArray(List<int> array, List<int> sequence)
        {
            int cantidadEncontradas = 0;
            int position = 0;
            for (int i = 0; i < array.Count; i++)
            {
                for (int j = 0; j < sequence.Count; j++)
                {
                    if (sequence[j] == array[i])
                    {
                        cantidadEncontradas++;
                    }
                }
            }
            if (cantidadEncontradas == sequence.Count)
                return true;
            return false;
        }

        public static bool Isvalidsubsequence(List<int> array, List<int> sequence)
        {
            int i = 0;
            int j = 0;
            while (i < array.Count && j < sequence.Count)
            {
                if (array[i] == sequence[j])
                {
                    j++;
                }
                i++;
            }
            return j == sequence.Count;
        }
    }
}