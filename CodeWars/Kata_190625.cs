using System.Linq;

namespace CodeWars
{
    internal class Kata_190625
    {
        // 1(4)
        public static string StripComments(string text, string[] commentSymbols)
        {
            string answ = "";
            bool isComment = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (isComment)
                {
                    if (text[i].ToString() == "\n")
                    {
                        isComment = false;
                        answ += text[i].ToString();
                    }
                }
                else
                {
                    if (commentSymbols.Contains(text[i].ToString()))
                    {
                        answ = answ.TrimEnd(' ');
                        isComment = true;
                    }
                    else if (text[i].ToString() == "\n")
                    {
                        answ = answ.TrimEnd(' ');
                        answ += text[i].ToString();
                    }
                    else
                        answ += text[i];
                }
            }

            answ = answ.TrimEnd(' ');

            return answ;
        }
    }
}
