using System;
using CustomExtension;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCalculatorApp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //unit test to validate  
            Calculate.CalculateTotal(1, 2);
        }
    }
}
