using System;

namespace LeetCode.Medium
{
    //https://leetcode.com/problems/determine-if-a-cell-is-reachable-at-a-given-time/?envType=daily-question&envId=2023-11-08
    public class LC2849
    {
        public bool IsReachableAtTime(int sx, int sy, int fx, int fy, int t)
        {
            // validate H case
            if (fx == sx && fy == sy)
                return t>1;


            var deltaX = Math.Abs(fx-sx);
            var deltaY = Math.Abs(fy-sy);

            // Chebyshev distance
            int max = Math.Max(deltaY, deltaX);

            return t>= max;
        }
    }
}
