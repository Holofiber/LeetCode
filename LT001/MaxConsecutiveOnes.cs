using NUnit.Framework;
using FluentAssertions;

namespace LeetCodeTest
{
    internal class MaxConsecutiveOnes
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

            public int FindMaxConsecutiveOnes(int[] nums)
            {
                int consecutiveCounter=1;
                int maxResult =0;

                for (int i = 0; i<nums.Length-1; i++)
                {
                    if (nums[i] == 1 && nums[i] == nums[i + 1])
                        consecutiveCounter++;
                    else
                    {
                        if (maxResult < consecutiveCounter)
                        maxResult = consecutiveCounter;

                        consecutiveCounter = 1;
                    }                      
                }

                if (maxResult < consecutiveCounter)
                    maxResult = consecutiveCounter;

                return maxResult;
            }


            [TestCase(3, new int[] { 1, 1, 0, 1, 1, 1 })]
            [TestCase(2, new int[] { 1, 0, 1, 1, 0, 1 })]
            [TestCase(0, new int[] {0})]
            [TestCase(1, new int[] { 1 })]
            [Test]
            public void Test1(int x, int[] y)
            {
                var res = FindMaxConsecutiveOnes(y);

               res.Should().Be(x);               
            }
        }
    }
}

