using LeetCode.Medium;
using NUnit.Framework;

namespace LeetCodeTest
{
    internal class LC2849Tests
    {
        [Test]
        [TestCase(5, 1, 1, 4, 4, true)]
        [TestCase(2, 1, 4, 3, 1, false)]
        [TestCase(1, 4, 4, 1, 4, true)]
        [TestCase(2, 4, 5, 2, 3, true)]
        [TestCase(2, 4, 7, 7, 6, true)]
        [TestCase(3, 1, 7, 3, 3, false)]
        [TestCase(1, 2, 1, 2, 1, false)]
        [TestCase(1, 1, 1, 1, 1, false)]
        [TestCase(1, 3, 3, 5, 2, true)]
        public void LC2038_ShouldBeTrue(int sx, int sy, int fx, int fy, int t, bool expected)
        {
            // Assert
            var lc2849 = new LC2849();

            var result = lc2849.IsReachableAtTime(sx, sy, fx, fy, t);

            Assert.AreEqual(expected, result);
        }
    }
}
