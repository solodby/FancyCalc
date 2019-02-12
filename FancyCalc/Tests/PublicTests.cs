﻿using System;
using NUnit.Framework;

namespace FancyCalc
{
    [TestFixture]
    public class FancyCalculatorTests
    {

        [Test]
        public void AddTest()
        {
            FancyCalcEnguine calc = new FancyCalcEnguine();
            double expected = 4;
            double actual = calc.Add(2, 2);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SubtractTest()
        {
            var calc = new FancyCalcEnguine();
            double expected = 0;
            double actual = calc.Subtract(1, 1);
            Assert.AreEqual(expected, actual);
        }
 [Test]
        public void MultiplyTest()
        {
            var calc = new FancyCalcEnguine();
            double expected = 9;
            double actual = calc.Multiply(3, 3);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CulculateMultiply()
        {
            var calc = new FancyCalcEnguine();
            double expected = 0;
            double actual = calc.Culculate("1 * 0");
            Assert.AreEqual(expected, actual);
        }
        [TestCase(3, 3, ExpectedResult = 9)]
        [TestCase(1, 0, ExpectedResult = 0)]
        public double MultiplyTest(int a, int b)
        {
            var calc = new FancyCalcEnguine();
            return calc.Multiply(a, b);
        }
    }
}
