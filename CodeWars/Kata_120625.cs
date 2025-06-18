using System;
using System.Collections.Generic;

namespace CodeWars
{
    internal class Kata_120625
    {
        // 1(7)
        public static string HighAndLow(string numbers)
        {
            List<int> numbs = new List<int>();

            foreach (var number in numbers.Split(' '))
                numbs.Add(Int32.Parse(number));

            numbs.Sort();

            return numbs[numbs.Count - 1] + " " + numbs[0];
        }



        //2(6)
        public static string Abbreviate(string input)
        {
            var counter = 0;
            var str = "";
            var n = input.Length;

            for (int i = 0; i < n; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    if (counter == 0)
                    {
                        str += input[i];
                        counter++;
                    }
                    else
                        counter++;
                }
                else
                {
                    if (counter == 0)
                        str += input[i];
                    else if (counter <= 3)
                    {
                        for (int j = i - counter + 1; j <= i; j++)
                            str += input[j];
                        counter = 0;
                    }
                    else
                    {
                        str += (counter - 2).ToString() + input[i - 1] + input[i];
                        counter = 0;
                    }
                }
            }

            if (counter <= 3)
                for (int i = n - counter + 1; i < n; i++)
                    str += input[i];
            else if (counter > 3)
                str += (counter - 2).ToString() + input[n - 1];

            return str;
        }


        
        //3(6)
        public static int Persistence(long n)
        {
            int k = 0;
            long l = 1;

            while (n / 10 > 0)
            {
                foreach (char numb in n.ToString())
                    l *= Int32.Parse(numb.ToString());

                k++;
                n = l;
                l = 1;
            }

            return k;
        }
    }
}
