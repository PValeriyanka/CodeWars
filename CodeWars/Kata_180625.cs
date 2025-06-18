using System;

namespace CodeWars
{
    internal class Kata_180625
    {
        // 1(6)
        public static bool Narcissistic(int value)
        {
            var str = value.ToString();
            int n = str.Length;

            double v = 0;

            foreach (char c in str)
                v += Math.Pow(c - '0', n);

            return (int)v == value;
        }



        // 2(6)
        public static string High(string s)
        {
            string word = "";
            int weight, MaxWeight = -1;

            foreach (string str in s.Split(' '))
            {
                weight = 0;
                foreach (char w in str)
                    weight += w - 96;

                if (weight > MaxWeight)
                {
                    MaxWeight = weight;
                    word = str;
                }
            }

            return word;
        }
    }
}
