namespace LeetCode.Medium
{
    public class LC2433
    {
        public int[] FindArray(int[] pref)
        {
            int[] result = new int[pref.Length];
            result[0] = pref[0];
            for (int i = 0; i < pref.Length-1; i++)
            {
                result[i+1] = pref[i] ^ pref[i+1];
            }

            return result;
        }
    }
}
