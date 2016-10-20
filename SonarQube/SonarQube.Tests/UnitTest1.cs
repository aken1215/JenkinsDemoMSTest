using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SonarQube.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Calculate()
        {
            var target = new Calculate();
            var first = 1;
            var second = 2;

            var actual = target.plus(first, second);
            var expected = 3;

            Assert.AreEqual(expected, actual);
        }
    }
}
