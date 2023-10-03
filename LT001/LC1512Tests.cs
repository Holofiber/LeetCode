using LeetCode;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTest
{
    internal class LC1512Tests
    {
        [Test]
        [TestCase(4, new int[] { 1, 2, 3, 1, 1, 3 })]
        [TestCase(6, new int[] { 1, 1, 1, 1 })]
        [TestCase(0, new int[] { 1, 2, 3 })]
        public void GoodPairs_ShouldReturn4(int expectredResult, int[] nums)
        {
            var GP = new LC1512_Number_of_good_pairs();

            var result = GP.NumIdenticalPairs(nums);

            Assert.AreEqual(expectredResult, result);
        }
    }
}
