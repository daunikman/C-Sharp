using System;
using NUnit.Framework;
using TestingCSharpTest;

namespace TestingCSharpTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Account account = new Account();
            Assert.True(true);
        }
    }
}