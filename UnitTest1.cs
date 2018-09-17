using System;
using CalculatorApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCalculatorApp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AdditionTestMethod()
        {
            //unit test to validate Calculate class addition
            //arrange
            var result = new CalculateTotalAddition();
            //act
            result.Operand1 = 10;
            result.Operand2 = 2;
            //assert (confirm expected - first number, confirm actual - second number)
            Assert.AreEqual(result.CalculateTotal(), 12);
        }
        [TestMethod]
        public void SubtractionTestMethod()
        {
            //unit test to validate Calculate class subtraction
            //arrange
            var subtraction = new CalculateTotalSubtraction();
            //act
            subtraction.Operand1 = 10;
            subtraction.Operand2 = 2;
            //assert
            Assert.AreEqual(subtraction.CalculateTotal(), 8);
        }
        [TestMethod]
        public void DivisionTestMethod()
        {
            //unit test to validate Calculate class division
            //arrange
            var division = new CalculateTotalDivision();
            //act
            division.Operand1 = 25;
            division.Operand2 = 5;
            //assert
            Assert.AreEqual(division.CalculateTotal(), 5);
        }
        [TestMethod]
        public void MultiplicationTestMethod()
        {
            //unit test to validate Calculate class multiplication
            //arrange
            var multiplication = new CalculateTotalMultiplication();
            //act
            multiplication.Operand1 = 10;
            multiplication.Operand2 = 2;
            //assert
            Assert.AreEqual(multiplication.CalculateTotal(), 20);
        }
    }
}
