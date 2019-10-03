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
            int[] Arr3 = new int[0];
            Boolean result1 = Program.CheckContain(Arr ,5);
            Assert.AreEqual(true, result1);

            Boolean result2 = Program.CheckContain(Arr2, 5);
            Assert.AreEqual(false, result2);

            Boolean result3 = Program.CheckContain(Arr3, 5);
            Assert.AreEqual(false, result3);
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

            Boolean result3 = Program.CheckContainOr(Arr3, 5, 6);
            Assert.AreEqual(false, result3);

            int[] Arr4 = new int[0];
            Boolean result4 = Program.CheckContainOr(Arr4, 5, 6);
            Assert.AreEqual(false, result4);
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

            Boolean result3 = Program.CheckContainAnd(Arr3, 5, 6);
            Assert.AreEqual(false, result3);

            int[] Arr4 = new int[0];
            Boolean result4 = Program.CheckContainAnd(Arr4, 5, 6);
            Assert.AreEqual(false, result4);
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

            int[] Arr3 = new int[0];
            int result3 = Program.Count(Arr3, 5);
            Assert.AreEqual(0, result3);
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

            int result3 = Program.CountOr(Arr3, 5, 6);
            Assert.AreEqual(0, result3);

            int[] Arr4 = new int[0];
            int result4 = Program.CountOr(Arr4, 5, 6);
            Assert.AreEqual(0, result4);
        }

        [TestMethod]
        public void TestSum()
        {
            int[] Arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int result1 = Program.SumValues(Arr);
            Assert.AreEqual(55, result1);

            int[] Arr2 = new int[0];
            int result2 = Program.SumValues(Arr2);
            Assert.AreEqual(0, result2);
        }
    }
}
