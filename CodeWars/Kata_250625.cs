using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    internal class Kata_250625
    {
        // 1(4) 
        public static long NextSmaller(long n)
        {
            List<int> numbs = new List<int>();
            List<int> min_numbs = new List<int>();
            string answ_1 = "";
            string answ_2 = "";

            foreach (char ch in n.ToString())
            {
                numbs.Add(int.Parse(ch.ToString()));
            }

            int i = numbs.Count - 1;

            if (i > 0)
            {
                min_numbs.Add(numbs[i]);
                while (i > 0)
                {
                    if (numbs[i - 1] <= numbs[i])
                    {
                        min_numbs.Add(numbs[i - 1]); 
                    }
                    else
                    {
                        int j = 0;
                        int min = numbs[i - 1];
                         
                        while (j < i - 1)
                        {
                            answ_1 += numbs[j];
                            j++;
                        }

                        min_numbs.Sort();

                        for (j = min_numbs.Count - 1; j >= 0; j--)
                        {
                            if (min <= min_numbs[j])
                            {
                                answ_2 += min_numbs[j];
                            }
                            else
                            {
                                answ_1 += min_numbs[j];
                                answ_2 += min;
                                min = -1;
                            }
                        }

                        answ_1 += answ_2;

                        if (answ_1[0] == '0')
                        {
                            return -1;
                        }
                        else
                        {
                            return long.Parse(answ_1);
                        }
                    }

                    i--;

                }
                return -1;
            }
            else
            {
                return -1;
            }
        }
    }
}
