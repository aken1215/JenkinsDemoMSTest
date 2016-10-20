using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestMsBuild;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMsBuild.Tests
{
    [TestClass()]
    public class CalculateTests
    {
        [TestMethod()]
        public void PlusTest()
        {
            var target = new Calculate();

            var first = 1;
            var second = 2;

            var actual = first + second;
            var expected = 3;

            Assert.AreEqual(expected, actual);
        }
    }
}