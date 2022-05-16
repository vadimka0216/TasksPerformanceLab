using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2;

namespace UnitTestTask2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double[] cycle = new double[]{ 1,1,5 };
            double X=2; double Y = 2;
            int expected = 1;
            int res=Program.Run(cycle,X,Y);
            Assert.AreEqual(expected, res);
        }
        [TestMethod]
        public void TestMethod2()
        {
            double[] cycle = new double[] { 0.5, -0.5, 1 };
            double X = 1.5; double Y = -0.5;
            int expected = 0;
            int res = Program.Run(cycle, X, Y);
            Assert.AreEqual(expected, res);
        }
        [TestMethod]
        public void TestMethod3()
        {
            double[] cycle = new double[] { 0.5, -0.5, 1 };
            double X = 1.5; double Y = -0.51;
            int expected = 2;
            int res = Program.Run(cycle, X, Y);
            Assert.AreEqual(expected, res);
        }
        [TestMethod]
        public void TestMethod4()
        {
            double[] cycle = new double[] { 1, 1, 5 };
            double X = 1; double Y = 6;
            int expected = 0;
            int res = Program.Run(cycle, X, Y);
            Assert.AreEqual(expected, res);
        }
    }
}
