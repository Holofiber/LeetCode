using NUnit.Framework;

namespace LeetCodeTest
{
    [TestFixture]
    public class Tests
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var lenght = nums.Length;

            for (int i = 0; i < lenght - 1; i++)
                for (int j = 1; j < lenght; j++)
                {
                    if (i == j)
                        continue;

                    var summ = nums[i] + nums[j];
                    if (summ == target)
                        return new int[] { i, j };
                }

            return null;
        }

        [TestCase(9, new int[] { 2, 7, 11, 15 }, new int[] { 0, 1 })]
        [TestCase(6, new int[] { 3, 2, 4 }, new int[] { 1, 2 })]
        [TestCase(6, new int[] { 3, 2, 3 }, new int[] { 0, 2 })]
        [TestCase(10, new int[] { 2, 5, 5, 11 }, new int[] { 1, 2 })]
        [Test]
        public void Test1(int x, int[] y, int[] z)
        {
            var res = TwoSum(y, x);

            Assert.AreEqual(z, res);
        }
    }
}