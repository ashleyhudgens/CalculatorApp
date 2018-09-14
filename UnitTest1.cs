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
            //unit test to validate Calculate class addition
            //arrange
            var result = new Calculate();
            //act
            result.Operand1 = 10;
            result.Operand2 = 2;
            //assert (confirm expected - first number, confirm actual - second number)
            Assert.AreEqual(12, 12);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var subtraction = new Calculate();
            subtraction.Operand1 = 10;
            subtraction.Operand2 = 2;
            Assert.AreEqual(8, 8);
        }
    }
}
