using System;
using NUnit.Framework;

namespace Logic.Tests
{
    [TestFixture]
    public class PolynomialTests
    {
        [Test]
        public void PolynomialTest_NullArray_ThrowException()
        {
            Assert.Catch<ArgumentNullException>(() => new Polynomial(null));
        }

        [Test]
        public void PolynomialTest_EqualsTest_SamePolynomials()
        {
            var p1 = new Polynomial(3.7, 12.1, 6.4);
            var p2 = new Polynomial(3.7, 12.1, 6.4);
            bool result1 = p1.Equals(p2);
            bool result2 = p1.GetHashCode() == p2.GetHashCode();
            Assert.AreEqual(true, result1);
            Assert.AreEqual(true, result2);
        }

        [Test]
        public void PolynomialTest_EqualsTest_NotSamePolynomials()
        {
            var p1 = new Polynomial(3.7, 12.2, 6.4);
            var p2 = new Polynomial(3.7, 12.1, 6.4);
            bool result1 = p1.Equals(p2);
            bool result2 = p1.GetHashCode() == p2.GetHashCode();
            Assert.AreEqual(false, result1);
            Assert.AreEqual(false, result2);
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