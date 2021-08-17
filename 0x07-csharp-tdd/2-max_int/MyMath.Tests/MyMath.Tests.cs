using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public static void emptyList()
        {
            int expectedResult = 0;
            int result = MyMath.Operations.Max(new List<int>());
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public static void regularArrayPositiveNumbers()
        {
            var input = new List<int>();
            input.Add(0);
            input.Add(1);
            input.Add(2);
            input.Add(3);
            input.Add(4);
            input.Add(5);

            int result = MyMath.Operations.Max(input);
            Assert.AreEqual(5, result);
        }

        [Test]
        public static void regularArrayNegativeNumbers()
        {
            var input = new List<int>() { -5, -4, -3, -2 };
            int result = MyMath.Operations.Max(input);
            Assert.AreEqual(-2, result);
        }
        [Test]
        public static void randomArray()
        {
            var input = new List<int>() { -50, 40, 89, -100 };
            int result = MyMath.Operations.Max(input);
            Assert.AreEqual(89, result);
        }
    }
}