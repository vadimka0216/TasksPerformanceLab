using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task4;

namespace UnitTestTask4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] args = new int[] { 1, 10, 2, 9 };
            int expected = 16;
            int result=Program.Run(args);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int[] args = new int[] { 1, 1, 2 };
            int expected = 1;
            int result = Program.Run(args);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int[] args = new int[] { 1, 1, 3, 1 };
            int expected = 2;
            int result = Program.Run(args);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod3_1()
        {
            int[] args = new int[] { 1, 1, 2, 1, 1 };
            int expected = 1;
            int result = Program.Run(args);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int[] args = new int[] { 1,2,3 };
            int expected = 2;
            int result = Program.Run(args);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod5()
        {
            int[] args = new int[] { -10,-5,5,10 };
            int expected = 30;
            int result = Program.Run(args);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod6()
        {
            int[] args = new int[] { 1,1,1,9,9,9};
            int expected = 24;
            int result = Program.Run(args);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod7()
        {
            int[] args = new int[] { 1, 1, 1, 9, 9, 9, 100};
            int expected = 3*8+100-9;
            int result = Program.Run(args);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod8()
        {
            int[] args = new int[] { 1,2 };
            int expected = 1;
            int result = Program.Run(args);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod9()
        {
            int[] args = new int[] {1};
            int expected = 0;
            int result = Program.Run(args);
            Assert.AreEqual(expected, result);
        }
    }
}
