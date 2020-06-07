using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Video_Rental_Arshdeep;

namespace UnitTestProject_Arshdeep
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            myUnitTest ownCode = new myUnitTest();
            var result = ownCode.Additions(5, 7);
            Assert.IsTrue(result == 12);
        }
    }
}
