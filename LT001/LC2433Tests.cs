using LeetCode.Medium;
using NUnit.Framework;

namespace LeetCodeTest
{
    internal class LC2433Tests
    {
        [Test]
        public void LC2433_ShouldBeTrue()
        {
            // Assert
            var lc2433 = new LC2433();

            int[] pref = new int[] { 5, 2, 0, 3, 1 };
            int[] expected = new int[] { 5, 7, 2, 3, 2 };

            var result = lc2433.FindArray(pref);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void LC2433_OneItem_ShouldBeTrue()
        {
            // Assert
            var lc2433 = new LC2433();

            int[] pref = new int[] { 5 };
            int[] expected = new int[] { 5};

            var result = lc2433.FindArray(pref);

            Assert.AreEqual(expected, result);
        }
    }
}
