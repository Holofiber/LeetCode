using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCodeTest
{
    internal class LC1245Tests
    {
        [Test]
        public void SeatManager_Test()
        {
            var st = new SeatManager(5);

            List<int> answers = new List<int>();

            answers.Add(st.Reserve());
            answers.Add(st.Reserve());
            st.Unreserve(2);
            answers.Add(st.Reserve());
            answers.Add(st.Reserve());
            answers.Add(st.Reserve());
            answers.Add(st.Reserve());
            st.Unreserve(5);

            var expected = new List<int>() { 1, 2, 2, 3, 4, 5 };

            Assert.AreEqual(expected, answers);
        }

        [Test]
        public void SeatManager_Test2()
        {
            var st = new SeatManager(5);

            List<int> answers = new List<int>();

            answers.Add(st.Reserve());
            answers.Add(st.Reserve());
            st.Unreserve(2);
            answers.Add(st.Reserve());
            answers.Add(st.Reserve());
            answers.Add(st.Reserve());
            answers.Add(st.Reserve());
            st.Unreserve(4);
            st.Unreserve(2);
            answers.Add(st.Reserve());


            var expected = new List<int>() { 1, 2, 2, 3, 4, 5, 2 };

            Assert.AreEqual(expected, answers);
        }
    }
}
