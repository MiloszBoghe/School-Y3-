using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace RefVsValue.Tests
{
    public class IntTests
    {
        [Test]
        public void TwoIntsAreNotTheSame()
        {
            int x = 32;
            int y = x;
            Assert.AreNotSame(x, y);
        }
        
        [Test]
        public void IntIsImmutable()
        {
            int x = 32;
            int y = x;

            Assert.AreEqual(x, y);

            x = 33;

            Assert.AreNotEqual(x, y);
        }
    }
}
