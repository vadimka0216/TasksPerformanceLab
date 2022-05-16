using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n = 5, m = 4;
            string expected = "14253";
            string result=Program.Run(n,m);
            Assert.AreEqual(expected,result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int n = 4, m = 3;
            string expected = "13";
            string result = Program.Run(n, m);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int n = 6, m = 6;
            string expected = "165432";
            string result = Program.Run(n, m);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int n = 1, m = 1;
            string expected = "1";
            string result = Program.Run(n, m);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod5()
        {
            int n = 2, m = 1;
            string expected = "1";
            string result = Program.Run(n, m);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod6()
        {
            int n = 3, m = 2;
            string expected = "123";
            string result = Program.Run(n, m);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod7()
        {
            int n = 2, m = 3;
            string expected = "1";
            string result = Program.Run(n, m);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod8()
        {
            int n = 1, m = 2;
            string expected = "1";
            string result = Program.Run(n, m);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod9()
        {
            int n = 4, m = 6;
            string expected = "1234";
            string result = Program.Run(n, m);
            Assert.AreEqual(expected, result);
        }
    }
}
