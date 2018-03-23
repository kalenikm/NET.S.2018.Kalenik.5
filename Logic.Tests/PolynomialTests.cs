﻿using NUnit.Framework;

namespace Logic.Tests
{
    [TestFixture]
    public class PolynomialTests
    {
        [Test]
        public void PolynomialTest_EqualsTest_SamePolynomials()
        {
            var p1 = new Polynomial(3.7, 12.1, 6.4);
            var p2 = new Polynomial(3.7, 12.1, 6.4);
            bool result = p1.Equals(p2);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void PolynomialTest_EqualsTest_NotSamePolynomials()
        {
            var p1 = new Polynomial(3.7, 12.2, 6.4);
            var p2 = new Polynomial(3.7, 12.1, 6.4);
            bool result = p1.Equals(p2);
            Assert.AreEqual(false, result);
        }

        [Test]
        public void PolynomialTest_SumTest()
        {
            var p1 = new Polynomial(3.7, 12.2, 6.4);
            var p2 = new Polynomial(3.7, 12.2, 6.4, 1.7, 1.2);
            var result = p1 + p2;
            var expected = new Polynomial(7.4, 24.4, 12.8, 1.7, 1.2); 
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void PolynomialTest_SubtractTest()
        {
            var p1 = new Polynomial(4.6, 15, 6.4);
            var p2 = new Polynomial(3.7, 12.2, 6.4, 1.7, 1.2);
            var result = p1 - p2;
            var expected = new Polynomial(0.9, 2.8, 0, -1.7, -1.2);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void PolynomialTest_MultiplyTest()
        {
            var p1 = new Polynomial(2.5, 3);
            var p2 = new Polynomial(1.8, 4.5);
            var result = p1 * p2;
            var expected = new Polynomial(4.5, 16.65, 13.5);
            Assert.AreEqual(expected, result);
        }
    }
}