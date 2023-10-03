using LeatCodeTasks;
using NUnit.Framework;

namespace LeetCodeTests
{
    public class LC2038Tests
    {
        [Test]
        [TestCase("AAABABB")]
        [TestCase("AAAAABBB")]
        [TestCase("AAAAABBBBBBAAAAA")]
        [TestCase("BBBAAAABB")]
        public void LC2038_ShouldBeTrue(string colors)
        {
            // Assert
            var lc2038 = new LC2038_RemoveColoredPieces();

            var result = lc2038.WinnerOfGame(colors);

            Assert.True(result);
        }

        [Test]
        [TestCase("AA")]
        [TestCase("ABBBBBBBAAA")]
        [TestCase("AAAABBBB")]
        [TestCase("BBBBAAAA")]
        public void LC2038_ShouldBeFalse(string colors)
        {
            // Assert
            var lc2038 = new LC2038_RemoveColoredPieces();

            var result = lc2038.WinnerOfGame(colors);

            Assert.False(result);
        }
    }
}
