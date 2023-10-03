using System.Linq;

namespace LeetCode
{
    public class LC1512_Number_of_good_pairs
    {
        public int NumIdenticalPairs(int[] nums)
        {
            int goodPairs = 0;

            foreach (int num in nums.Distinct().ToList())
            {
                int pairs = nums.Where(x => x.Equals(num)).Count();

                goodPairs += ((pairs - 1) * pairs / 2);
            }

            return goodPairs;
        }
    }
}
