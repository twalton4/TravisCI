using System;
using NUnit.Framework;

namespace TravisCILab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_ValidWalton()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_InvalidWalton()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_NullWalton()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        // Implement 3 tests per operation, following a similar pattern as above

        [Test]
        public void Subtract_ValidWalton()
        {
            Assert.AreEqual(2, Program.Subtract("4", "2"));
            Assert.AreEqual(0, Program.Subtract("5", "5"));
            Assert.AreEqual(-3, Program.Subtract("2", "5"));
        }

        [Test]
        public void Subtract_InvalidWalton()
        {
            Assert.Throws<FormatException>(() => Program.Subtract("1", "b"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "1"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "a"));
        }

        [Test]
        public void Subtract_NullWalton()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Subtract("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, null));
        }

        [Test]
        public void Multiply_ValidWalton()
        {
            Assert.AreEqual(10, Program.Multiply("5", "2"));
            Assert.AreEqual(0, Program.Multiply("0", "5"));
            Assert.AreEqual(48, Program.Multiply("6", "8"));
        }

        [Test]
        public void Multiply_InvalidWalton()
        {
            Assert.Throws<FormatException>(() => Program.Multiply("1", "b"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "1"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "a"));
        }

        [Test]
        public void Multiply_NullWalton()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Multiply("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, null));
        }

        [Test]
        public void Divide_ValidWalton()
        {
            Assert.AreEqual(5, Program.Divide("10", "2"));
            Assert.AreEqual(0, Program.Divide("0", "3"));
            Assert.AreEqual(4, Program.Divide("64", "16"));
        }

        [Test]
        public void Divide_InvalidWalton()
        {
            Assert.Throws<FormatException>(() => Program.Divide("1", "b"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "1"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "a"));
        }

        [Test]
        public void Divide_NullWalton()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Divide("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, null));
        }

        [Test]
        public void Power_ValidWalton()
        {
            Assert.AreEqual(64, Program.Power("2", "6"));
            Assert.AreEqual(1, Program.Power("13", "0"));
            Assert.AreEqual(100, Program.Power("10", "2"));
        }

        [Test]
        public void Power_InvalidWalton()
        {
            Assert.Throws<FormatException>(() => Program.Power("1", "b"));
            Assert.Throws<FormatException>(() => Program.Power("a", "1"));
            Assert.Throws<FormatException>(() => Program.Power("a", "a"));
        }

        [Test]
        public void Power_NullWalton()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Power("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, null));
        }

    }
}
