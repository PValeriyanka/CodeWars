namespace CodeWars
{
    internal class Kata_230625
    {
        // 1(4) 
        public static string Extract(int[] args)
        {
            int k = 0, i = 0;
            int n = args.Length;
            string answ = "";

            for (int j = 1; j < n; j++)
            {
                if (args[j] - args[j - 1] == 1)
                {
                    k++;
                }
                else
                {
                    if (k >= 2)
                    {
                        answ += args[i].ToString() + "-" + args[j - 1].ToString() + ",";
                        k = 0;
                    }
                    else
                    {
                        for (int z = i; z < j; z++)
                        {
                            answ += args[z] + ",";
                            k = 0;
                        }
                    }
                    i = j;
                }
            }

            if (k >= 2)
            {
                answ += args[i].ToString() + "-" + args[n - 1].ToString() + ",";
            }
            else
            {
                for (int z = i; z < n; z++)
                {
                    answ += args[z] + ",";
                }
            }

            return answ.Substring(0, answ.Length - 1);
        }
    }
}
