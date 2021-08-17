using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    public class Tests
    {
        [Test]
        public static void positiveNumbers()
        {
            List<int> list1 = new List<int>() { 0, 1, 2, 3, 4, 5 };
            Assert.AreEqual(MyMath.Operations.Max(list1), 5);
        }

        [Test]
        public static void negativeNumbers()
        {
            List<int> list2 = new List<int>() { -5, -4, -3, -2, -1 };
            Assert.AreEqual(MyMath.Operations.Max(list2), -1);
        }

        [Test]
        public static void randomList()
        {
            List<int> list3 = new List<int>() { 89, -101, 27, -300, 46, 57 };
            Assert.AreEqual(MyMath.Operations.Max(list3), 89);
        }

        [Test]
        public static void emplyList()
        {
            List<int> list4 = new List<int>();
            Assert.AreEqual(MyMath.Operations.Max(list4), 0);
        }
      
    }
}