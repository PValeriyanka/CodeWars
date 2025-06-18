using System.Collections.Generic;

namespace CodeWars
{
    internal class Kata_130625
    {
        // 1(6)
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            HashSet<int> setb = new HashSet<int>(b);
            List<int> c = new List<int>();

            foreach (int numb in a)
            {
                if (!setb.Contains(numb))
                    c.Add(numb);
            }

            return c.ToArray();
        }



        // 2(6)
        public static bool validBraces(string braces)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in braces)
            {
                switch (c)
                {
                    case '(':
                    case '[':
                    case '{':
                        stack.Push(c);
                        break;

                    case ')':
                        if (stack.Count == 0 || (stack.Pop() != '('))
                            return false;
                        break;

                    case ']':
                        if (stack.Count == 0 || (stack.Pop() != '['))
                            return false;
                        break;

                    case '}':
                        if (stack.Count == 0 || (stack.Pop() != '{'))
                            return false;
                        break;
                }
            }

            return stack.Count == 0;
        }



        // 3(5) 
        public static string PigIt(string str)
        {
            str += " ";
            string answ = "";
            string boof = "ay";

            foreach (char s in str)
            {
                if (char.IsLetter(s) && boof == "ay")
                    boof = s + "ay";
                else if (!char.IsLetter(s) && boof != "ay")
                {
                    answ += boof + s;
                    boof = "ay";
                }
                else
                    answ += s;
            }

            return answ.Substring(0, answ.Length - 1);
        }
    }
}
