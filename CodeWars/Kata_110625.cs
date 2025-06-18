using System;
using System.Text;

namespace CodeWars
{
    internal class Kata_110625
    {
        // 1(8)
        public static bool ValidateHello(string greetings)
        {
            greetings = greetings.ToLower();
            return greetings.Contains("hello") ||
                   greetings.Contains("ciao") ||
                   greetings.Contains("salut") ||
                   greetings.Contains("hallo") ||
                   greetings.Contains("hola") ||
                   greetings.Contains("ahoj") ||
                   greetings.Contains("czesc");
        }



        // 2(7)
        public static int SquareDigits(int n)
        {
            StringBuilder str = new StringBuilder("");

            if (n == 0)
            {
                str.Append("0");
            }

            while (n > 0)
            {
                str.Insert(0, Math.Pow(n % 10, 2));
                n /= 10;
            }

            return Int32.Parse(str.ToString());
        }



        // 3(6)
        public static int DigitalRoot(long n)
        {
            long sum = 0;
            while (n / 10 > 0)
            {
                while (n > 0)
                {
                    sum += n % 10;
                    n = n / 10;
                }
                n = sum;
                sum = 0;
            }
            return (int)n;
        }
    }
}
