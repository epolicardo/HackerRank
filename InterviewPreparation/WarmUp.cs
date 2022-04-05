using System;

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
            int count = 0;
            int longitud = s.Length;
            string cadenaAProcesar = "";
            if (s.Equals("a"))
            {
                return n;
            }
   
             while(cadenaAProcesar.Length < n)
                {
                    cadenaAProcesar = cadenaAProcesar + s;

                }   
        
            if (cadenaAProcesar.Length >= 1 && cadenaAProcesar.Length <= 100)
            {
                cadenaAProcesar = cadenaAProcesar.Substring(0, (int)n);
                    char[] vs = cadenaAProcesar.ToArray();
                    foreach (var item in vs)
                    {
                        if (item.Equals('a'))
                        {
                            count++;
                        }
                    }
            }
            return count; 
        }
    }
}