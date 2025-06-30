using System;
using System.Linq;

public class Kata_300625
{
    // 1(4)
    public static int LongestSlideDown(int[][] pyramid)
    {
        var answs = pyramid[pyramid.Length - 1].ToArray();

        for (int i = pyramid.Length - 2; i >= 0; i--)
        {
            for (int j = 0; j < pyramid[i].Length; j++)
            {
                answs[j] = pyramid[i][j] + Math.Max(answs[j], answs[j + 1]);
            }
        }

        return answs[0];
    }
}