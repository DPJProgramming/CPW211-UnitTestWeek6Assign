using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW211_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode.Tests
{
    [TestClass()]
    public class SimpleMathTests
    {
        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
        {
            double expectedSum = num1 + num2;
            Assert.AreEqual(expectedSum, SimpleMath.Add(num1, num2));
        }

        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(0, 0)]
        [DataRow(23.5, 34.678)]
        public void Multiply_TwoNumbers_ReturnsProduct(double num1, double num2)
        {
            double expectedProduct = num1 * num2;
            Assert.AreEqual(expectedProduct, SimpleMath.Multiply(num1, num2));
        }

        [TestMethod]
        [DataRow(5, 0)]
        [DataRow(0, 0)]
        [DataRow(98.292, 0)]
        public void Divide_DenominatorZero_ThrowsArgumentException(double numerator, double denominator)
        {
            Assert.ThrowsException<DivideByZeroException>(() => SimpleMath.Divide(numerator, denominator));
        }

        [TestMethod]
        [DataRow(20, 3.2)]
        [DataRow(1, 100)]
        [DataRow(-15.3, 45.1)]
        public void Divide_TwoNumbers_ReturnsQuotient(double num1, double num2) {
            double expectedQuotient = num1 / num2;
            Assert.AreEqual(expectedQuotient, SimpleMath.Divide(num1, num2));
        }

        // TODO: Test subtract method with two valid numbers
        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(0, 0)]
        public void Subtract_SubtractTwoNumber_ReturnsDifference(double num1, double num2) {
            double expectedDifference = num1 - num2;
            Assert.AreEqual(expectedDifference, SimpleMath.Subtract(num1, num2));
        }
    }
}