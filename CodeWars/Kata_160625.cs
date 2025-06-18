using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    internal class Kata_160625
    {
        // 1(5)
        public static string orderWeight(string strng)
        {
            var pair = new List<KeyValuePair<int, string>>();
            int sum;

            foreach (string str in strng.Split(' '))
            {
                if (str != "")
                {
                    sum = 0;

                    foreach (char i in str)
                        sum += i - '0';

                    pair.Add(new KeyValuePair<int, string>(sum, str));
                }
            }

            strng = "";

            foreach (var p in pair.OrderBy(x => x.Value).OrderBy(x => x.Key))
                strng += p.Value + " ";

            return strng.TrimEnd();
        }



        // 2(5)
        public static string Interpret(string s)
        {
            List<int> letters = new List<int>();
            Stack<int> Ws = new Stack<int>();
            letters.Add(0);
            int buffer = 0, j = 0, z = -1, k;
            string answ = "";

            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case '+': letters[j]++; letters[j] = Check(letters[j]); break;
                    case '-': letters[j]--; letters[j] = Check(letters[j]); break;
                    case '>':
                        if (j == letters.Count - 1)
                            letters.Add(0);
                        j++;
                        break;
                    case '<':
                        if (j == 0)
                            letters.Insert(0, 0);
                        else
                            j--;
                        break;
                    case 'c': buffer = letters[j]; break;
                    case 'p': letters[j] = buffer; break;
                    case 'W':
                        Ws.Push(i);
                        if (letters[j] == 0)
                        {
                            k = 1;
                            while (k > 0)
                            {
                                i++;
                                if (s[i] == 'W')
                                    k++;
                                if (s[i] == 'E')
                                    k--;
                            }
                            Ws.Pop();
                        }
                        break;
                    case 'E':
                        if (letters[j] != 0)
                            i = Ws.Peek();
                        else
                            Ws.Pop();
                        break;
                    case 'P': answ += (char)letters[j]; break;
                    case 'N': answ += letters[j]; break;
                    case 'T': letters[j] *= 2; letters[j] = Check(letters[j]); break;
                    case 'Q': letters[j] = (int)Math.Pow(letters[j], 2); letters[j] = Check(letters[j]); break;
                    case 'U': letters[j] = (int)Math.Sqrt(letters[j]); break;
                    case 'L': letters[j] += 2; letters[j] = Check(letters[j]); break;
                    case 'I': letters[j] -= 2; letters[j] = Check(letters[j]); break;
                    case 'V': letters[j] = letters[j] / 2; break;
                    case 'A': letters[j] += buffer; letters[j] = Check(letters[j]); break;
                    case 'B': letters[j] -= buffer; letters[j] = Check(letters[j]); break;
                    case 'Y': letters[j] *= buffer; letters[j] = Check(letters[j]); break;
                    case 'D': letters[j] = letters[j] / buffer; break;
                    default: break;
                }
            }

            return answ;
        }

        public static int Check(int a)
        {
            if (a > 255)
                a = 256 - a;
            else if (a < 0)
                a = 256 + a;
            return a;
        }
    }
}
