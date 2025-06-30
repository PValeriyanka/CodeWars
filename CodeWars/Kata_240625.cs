using System;
using System.Collections.Generic;

namespace CodeWars
{
    internal class Kata_240625
    {
        // 1(4) 
        public static int[] Snail(int[][] array)
        {
            List<int> list = new List<int>();
            
            if ( array.Length > 0 && array[0].Length > 0 ) 
            {
                int n = array.Length;
                int m = (int)Math.Pow(n, 2);
                int k = 0;
                int h = 0;
                bool vert = false;
                bool reverse = false;

                while (m > 1)
                {
                    if (!vert)
                    {
                        if (!reverse)
                        {
                            for (int j = k; j < n - 1; j++)
                            {
                                list.Add(array[h][j]);
                                m--;
                            }

                            h = n - 1;
                        }
                        else
                        {
                            for (int j = n - 1; j > k; j--)
                            {
                                list.Add(array[h][j]);
                                m--;
                            }

                            h = k;
                        }

                        vert = true;
                    }
                    else
                    {
                        if (!reverse)
                        {
                            for (int i = k; i < n - 1; i++)
                            {
                                list.Add(array[i][h]);
                                m--;
                            }

                            reverse = true;
                        }
                        else
                        {
                            for (int i = n - 1; i > k; i--)
                            {
                                list.Add(array[i][h]);
                                m--;
                            }

                            k++;
                            h = k;
                            n--;
                            reverse = false;
                        }

                   
                        vert = false;
                    }
                }

                if (!vert)
                {
                    list.Add(array[h][k]);
                }
                else
                {
                    list.Add(array[k+1][h]);
                }
            }
            
            return list.ToArray();
        }
    }
}
