using System.Collections.Generic;

namespace CodeWars
{
    internal class Kata_170625
    {
        // 1(5)
        public static int? chooseBestSum(int t, int k, List<int> ls)
        {
            var sums = new List<int>();

            int n = ls.Count;

            if (n >= k)
            {
                for (int i = 0; i <= n - k; i++)
                    CreateFor(ls, i, k, n, 1, ls[i], sums);

                sums.Sort();

                for (int i = sums.Count - 1; i >= 0; i--)
                {
                    if (sums[i] <= t)
                        return sums[i];
                }
            }

            return null;
        }

        static void CreateFor(List<int> ls, int i, int k, int n, int z, int sum, List<int> sums)
        {
            if (z == k)
            {
                sums.Add(sum);
                return;
            }

            for (int j = i + 1; j < n; j++)
                CreateFor(ls, j, k, n, z + 1, sum + ls[j], sums);
        }
    }
}
