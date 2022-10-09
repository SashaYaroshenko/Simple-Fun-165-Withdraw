namespace myjinxin
{
    using NUnit.Framework;
    using System;
    using ConsoleApp1;

    [TestFixture]
    public class myjinxin
    {

        [Test]
        public void BasicTests()
        {
           // var kata = new Kata();

            Assert.AreEqual(new int[] { 0, 0, 2 }, Kata.Withdraw(40));

            Assert.AreEqual(new int[] { 2, 1, 0 }, Kata.Withdraw(250));

            Assert.AreEqual(new int[] { 2, 0, 3 }, Kata.Withdraw(260));

            Assert.AreEqual(new int[] { 1, 1, 4 }, Kata.Withdraw(230));

            Assert.AreEqual(new int[] { 0, 0, 3 }, Kata.Withdraw(60));

        }

    }
}
