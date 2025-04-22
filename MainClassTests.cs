using NUnit.Framework;
using System;
using LearnDLL;

namespace LearnDllTests
{
    [TestFixture]
    public class MainClassTests
    {
        [Test]
        public void Constructor_WithValidValue_DoesNotThrow()
        {
            Assert.DoesNotThrow(() => new MainClass(100));
        }

        [Test]
        public void Constructor_WithTooLargeValue_ThrowsException()
        {
            Assert.Throws<Exception>(() => new MainClass(256));
        }

        [Test]
        public void Constructor_WithNegativeValue_ThrowsException()
        {
            Assert.Throws<Exception>(() => new MainClass(-1));
        }

        [Test]
        public void GetDifference_NormalCase_ReturnsCorrect()
        {
            var obj = new MainClass(200);
            int result = obj.GetDifference(50);
            Assert.AreEqual(150, result);
        }

        [Test]
        public void GetDifference_TooHigh_ReturnsZero()
        {
            var obj = new MainClass(200);
            int result = obj.GetDifference(300);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void GetDifference_TooLow_Returns255()
        {
            var obj = new MainClass(200);
            int result = obj.GetDifference(-100);
            Assert.AreEqual(255, result, "Expected 255 for negative value, but got " + result);
        }
    }
}
