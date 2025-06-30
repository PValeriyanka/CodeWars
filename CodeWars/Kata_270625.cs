using System;

public class Kata_270625
{
    // 1(4)
    public static string Add(string a, string b)
    {
        int i, j;
        string buff = "0", big, small, k, answ = "";
        
        if (a.Length >= b.Length)
        {
            big = a;
            i = a.Length;
            small = b;
            j = b.Length;
        }
        else
        {
            big = b;
            i = b.Length;
            small = a;
            j = a.Length;
        }

        while (i > 0)
        {
            if (j < 1)
            {
                k = "0";
            }
            else
            {
                k = small[j - 1].ToString();
            }

            if (buff.Length > 1)
            {
                buff = (Int32.Parse(buff[0].ToString()) + Int32.Parse(k) + Int32.Parse(big[i - 1].ToString())).ToString();
            }
            else
            {
                buff = (Int32.Parse(k) + Int32.Parse(big[i - 1].ToString())).ToString();
            }

            j--;
            i--;

            if (buff.Length > 1 && i != 0)
            {
                answ = answ.Insert(0, buff[buff.Length - 1].ToString());
            }
            else
            {
                answ = answ.Insert(0, buff);
            }
        }

        return answ;
    }
}