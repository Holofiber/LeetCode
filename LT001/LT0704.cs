using NUnit.Framework;

namespace LeetCodeTest
{
    [TestFixture]
    public class Tests0704
    {
        public int Search(int[] nums, int target)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] == target)
                    return i;
            }

            return -1;
        }

        [TestCase(9, new int[] { -1, 0, 3, 5, 9, 12 }, 4)]
        [TestCase(2, new int[] { -1, 0, 3, 5, 9, 12 }, -1)]
        //[TestCase(6, new int[] { 3, 2, 3 }, new int[] { 0, 2 })]
       // [TestCase(10, new int[] { 2, 5, 5, 11 }, new int[] { 1, 2 })]
        [Test]
        public void Test0704(int x, int[] y, int z)
        {
            var res = Search(y, x);

            Assert.AreEqual(z, res);
        }
    }

   
}
