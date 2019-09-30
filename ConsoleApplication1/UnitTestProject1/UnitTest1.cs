using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsOdd()
        {
            bool result3 = Program.IsOdd(3);
            Assert.AreEqual(true, result3);

            bool result4 = Program.IsOdd(4);
            Assert.AreEqual(false, result4);
        }

        [TestMethod]
        public void TestIsEven()
        {
            bool result3 = Program.IsEven(3);
            Assert.AreEqual(false, result3);

            bool result4 = Program.IsEven(4);
            Assert.AreEqual(true, result4);
        }

        [TestMethod]
        public void TestIsPrime()
        {
            bool result1 = Program.IsPrime(-3);
            Assert.AreEqual(false, result1);

            bool result2 = Program.IsPrime(0);
            Assert.AreEqual(false, result2);

            bool result3 = Program.IsPrime(3);
            Assert.AreEqual(true, result3);

            bool result4 = Program.IsPrime(4);
            Assert.AreEqual(false, result4);
        }

        [TestMethod]
        public void TestSquare()
        {
            int result1 = Program.Square(-3);
            Assert.AreEqual(9, result1);

            int result2 = Program.Square(3);
            Assert.AreEqual(9, result2);
        }

        [TestMethod]
        public void TestCube()
        {
            int result1 = Program.Cube(-3);
            Assert.AreEqual(-27, result1);

            int result2 = Program.Cube(3);
            Assert.AreEqual(27, result2);
        }

        public void TestPow()
        {
            double result1 = Program.Pow(0,1);
            Assert.AreEqual(0, result1);

            double result2 = Program.Pow(0, -1);
            Assert.AreEqual(0, result2);

            double result3 = Program.Pow(2, 0);
            Assert.AreEqual(1, result3);

            double result4 = Program.Pow(2, 2);
            Assert.AreEqual(4, result4);

            double result5 = Program.Pow(2, -2);
            Assert.AreEqual(1/4, result5);
        }
    }
}
