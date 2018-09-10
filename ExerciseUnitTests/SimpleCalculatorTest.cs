using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace ExerciseUnitTests
{
    [TestClass]
    public class SimpleCalculatorTest
    {
        SimpleCalculator calculator;
        [TestInitialize]
        public void Initialise()
        {
            calculator = new SimpleCalculator(10,5);
        }
        [TestMethod]
        public void TestAddition()
        {
            Assert.AreEqual(23, SimpleCalculator.Add(10, 13));
        }

        [TestMethod]
        public void TestDivide()
        {
            Assert.AreEqual(5, calculator.Divide(20, 4));
        }

        [TestMethod]
        public void TestMultiplication()
        {
            Assert.AreEqual(42, SimpleCalculator.Multiplication(7, 6));
        }
    }
}
