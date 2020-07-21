using NUnit.Framework;
using TestingCSharp;

namespace TestProject1
{
    public class Tests
    {
        private Account _account;
        [SetUp]
        public void Setup()
        {
            _account = new Account();
        }

        [Test]
        public void Test1()
        {
            _account.Balance = 1000;
            _account.DepositCash(2500);
            Assert.
        }
    }
}