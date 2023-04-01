using System;
using System.Linq;

namespace HackerRank
{
    public static class WarmUp
    {
        public static int jumpingCouds(List<int> clouds)
        {

            var Position = 0;
            var jumpCount = 0;
            while (true)
            {
                if (Position + 2 <= clouds.Count - 1 && clouds[Position + 2] == 0)
                    Position = Position + 2;
                else
                    Position++;

                jumpCount++;
                if (Position == clouds.Count - 1)
                    break;
            }
            return jumpCount;
        }

        //s= abcac
        //n = 10 Primeras 10 letras de la cadena "abcacabcac"
        public static long RepeatedString(string s, long n)
        {
            long size = s.Length, repeated = n / size;
            long left = n - (size * repeated);
            int extra = 0;

            int count = 0;
            for (int i = 0; i < size; i++)
            {
                if (s[i] == 'a')
                {
                    ++count;
                }
            }

            for (int i = 0; i < left; i++)
            {
                if (s[i] == 'a')
                {
                    ++extra;
                }
            }

            repeated = (repeated * count) + extra;

            return repeated;
        }
    }
}