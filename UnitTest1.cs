using System;
using CalculatorApp;
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
            //arrange
            var Calculator = new Calculate();
            //act
            var result = Calculator.CalculateTotal(10, 2);
            //assert
            Assert.AreEqual(12, result);
        }
    }
}
