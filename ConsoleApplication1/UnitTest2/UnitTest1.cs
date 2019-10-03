using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication2;

namespace UnitTest2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestContain()
        {
            int []  Arr = {5,6,8,6,9,10,42,56,31,100};
            int[] Arr2 = { 6, 6, 8, 6, 9, 10, 42, 56, 31, 100 };
            Boolean result1 = Program.CheckContain(Arr ,5);
            Assert.AreEqual(true, result1);

            Boolean result2 = Program.CheckContain(Arr2, 5);
            Assert.AreEqual(false, result2);
        }


        [TestMethod]
        public void TestContainOr()
        {
            int[] Arr = { 5, 6, 8, 6, 9, 10, 42, 56, 31, 100 };
            int[] Arr2 = { 6, 6, 8, 6, 9, 10, 42, 56, 31, 100 };
            int[] Arr3 = { 1, 7, 8, 3, 9, 10, 42, 56, 31, 100 };
            Boolean result1 = Program.CheckContainOr(Arr, 5, 6);
            Assert.AreEqual(true, result1);

            Boolean result2 = Program.CheckContainOr(Arr2, 5, 6);
            Assert.AreEqual(true, result2);

            Boolean result3 = Program.CheckContainOr(Arr2, 5, 6);
            Assert.AreEqual(false, result3);
        }


        [TestMethod]
        public void TestContainAnd()
        {
            int[] Arr = { 5, 6, 8, 6, 9, 10, 42, 56, 31, 100 };
            int[] Arr2 = { 6, 6, 8, 6, 9, 10, 42, 56, 31, 100 };
            int[] Arr3 = { 1, 7, 8, 3, 9, 10, 42, 56, 31, 100 };
            Boolean result1 = Program.CheckContainAnd(Arr, 5, 6);
            Assert.AreEqual(true, result1);

            Boolean result2 = Program.CheckContainAnd(Arr2, 5, 6);
            Assert.AreEqual(false, result2);

            Boolean result3 = Program.CheckContainAnd(Arr2, 5, 6);
            Assert.AreEqual(false, result3);
        }

        [TestMethod]
        public void TestCount()
        {
            int[] Arr = { 5, 6, 8, 6, 9, 10, 42, 56, 31, 100 };
            int[] Arr2 = { 6, 6, 8, 6, 9, 10, 42, 56, 31, 100 };
            int result1 = Program.Count(Arr, 5);
            Assert.AreEqual(1, result1);

            int result2 = Program.Count(Arr2, 5);
            Assert.AreEqual(0, result2);
        }

        [TestMethod]
        public void TestCountOr()
        {
            int[] Arr = { 5, 6, 8, 6, 9, 10, 42, 56, 31, 100 };
            int[] Arr2 = { 6, 6, 8, 6, 9, 10, 42, 56, 31, 100 };
            int[] Arr3 = { 1, 7, 8, 3, 9, 10, 42, 56, 31, 100 };
            int result1 = Program.CountOr(Arr, 5, 6);
            Assert.AreEqual(3, result1);

            int result2 = Program.CountOr(Arr2, 5, 6);
            Assert.AreEqual(3, result2);

            int result3 = Program.CountOr(Arr2, 5, 6);
            Assert.AreEqual(0, result3);
        }
    }
}
