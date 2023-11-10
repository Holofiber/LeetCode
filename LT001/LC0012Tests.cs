using NUnit.Framework;
using System.Linq;

namespace LeetCodeTest
{
    internal class LC0012Tests
    {
        [Test]
        [TestCase(3, "III")]
        [TestCase(58, "LVIII")]
        [TestCase(3999, "MMMCMXCIX")]
        [TestCase(1994, "MCMXCIV")]
        public void IntToRoman(int num, string expected)
        {
            string Roman = "";

            int[] numArr = num.ToString().ToCharArray().Select(c => int.Parse(c.ToString())).ToArray();
            string letter = "I";
            int p = 1;

            for (int i = num.ToString().Length; i > 0; i--)
            {
                var n = numArr[i - 1] / p;
                Roman = BuildNumber(n, letter) + Roman;

                letter = NextPositionLetter(letter);
                n = n * 10;
            }

            Assert.AreEqual(expected, Roman);
        }

        private string BuildNumber(int num, string letter)
        {
            switch (num)
            {
                case 1:
                case 2:
                case 3:
                    return string.Concat(Enumerable.Repeat(letter, num));
                case 4:
                    return letter + NextLetter(letter);
                case 5:
                    return NextLetter(letter);
                case 6:
                    return NextLetter(letter) + letter;
                case 7:
                    return NextLetter(letter) + letter + letter;
                case 8:
                    return NextLetter(letter) + letter + letter + letter;
                case 9:
                    return letter + NextLetter(NextLetter(letter));
                case 10: return NextLetter(NextLetter(letter));
                default:
                    return "";
            }
        }

        private string NextLetter(string letter)
        {
            switch (letter)
            {
                case "I":
                    return "V";
                case "V":
                    return "X";
                case "X":
                    return "L";
                case "L":
                    return "C";
                case "C":
                    return "D";
                case "D":
                    return "M";
                default:
                    return "";
            }
        }

        private string NextPositionLetter(string letter)
        {
            switch (letter)
            {
                case "I":
                    return "X";
                case "X":
                    return "C";
                case "C":
                    return "M";
                default:
                    return "";
            }
        }
    }

    //  I             1
    //  V             5
    //  X             10
    //  L             50
    //  C             100
    //  D             500
    //  M             1000
}
