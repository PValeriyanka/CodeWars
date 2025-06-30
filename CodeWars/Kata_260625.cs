public class Kata_260625
{
    // 1(5)
    public static long[] Smallest(long n)
    {
        string s = n.ToString();
        long min = n;
        int bestI = 0, bestJ = 0;

        for (int i = 0; i < s.Length; i++)
        {
            char ch = s[i];
            string temp = s.Remove(i, 1);

            for (int j = 0; j <= temp.Length; j++)
            {
                string str = temp.Insert(j, ch.ToString());
                long numb = long.Parse(str);

                if (numb < min || (numb == min && i < bestI) || (numb == min && i == bestI && j < bestJ))
                {
                    min = numb;
                    bestI = i;
                    bestJ = j;
                }
            }
        }

        return new long[] { min, bestI, bestJ };
    }
}