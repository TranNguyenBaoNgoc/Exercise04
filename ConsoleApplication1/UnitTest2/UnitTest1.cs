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
    }
}
