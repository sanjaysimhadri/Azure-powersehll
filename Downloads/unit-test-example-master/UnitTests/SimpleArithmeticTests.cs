using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class SimpleArithmeticTests
    {
        [TestMethod]
        public void TestAddition()
        {
            var simpleArithmetic = new SimpleArithmetic();

            Assert.IsTrue(simpleArithmetic.Addition(1, 1) == 2);
        }

        [TestMethod]
        public void TestSubtraction()
        {
            var simpleArithmetic = new SimpleArithmetic();

            Assert.IsTrue(simpleArithmetic.Subtraction(1, 1) == 0);
        }

        [TestMethod]
        public void TestMultiplication()
        {
            var simpleArithmetic = new SimpleArithmetic();

            Assert.IsTrue(simpleArithmetic.Multiplication(2, 10) == 20);
        }

        [TestMethod]
        public void TestDivision()
        {
            var simpleArithmetic = new SimpleArithmetic();

            Assert.IsTrue(simpleArithmetic.Division(8, 2) == 4);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivisionByZero()
        {
            var simpleArithmetic = new SimpleArithmetic();

            simpleArithmetic.Division(2,0);
        }
    }
}