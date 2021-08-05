using NUnit.Framework;
using ConvertorBCD;

namespace ConvertorBCDTests
{
    public class ConvertorBCDTests
    {
        [Test]
        public void TestWith1Digit()
        {
            Assert.AreEqual("0000 ", Convertor.ConvertToBCD("0"));
            Assert.AreEqual("0001 ", Convertor.ConvertToBCD("1"));
            Assert.AreEqual("0010 ", Convertor.ConvertToBCD("2"));
            Assert.AreEqual("0011 ", Convertor.ConvertToBCD("3"));
            Assert.AreEqual("0100 ", Convertor.ConvertToBCD("4"));
            Assert.AreEqual("0101 ", Convertor.ConvertToBCD("5"));
            Assert.AreEqual("0110 ", Convertor.ConvertToBCD("6"));
            Assert.AreEqual("0111 ", Convertor.ConvertToBCD("7"));
            Assert.AreEqual("1000 ", Convertor.ConvertToBCD("8"));
            Assert.AreEqual("1001 ", Convertor.ConvertToBCD("9"));
        }

        [Test]
        public void TestWith2Digits()
        {
            Assert.AreEqual("0101 0110 ", Convertor.ConvertToBCD("56"));
            Assert.AreEqual("0110 0101 ", Convertor.ConvertToBCD("65"));
        }

        [Test]
        public void TestWith3Digits()
        {
            Assert.AreEqual("0011 0000 0101 ", Convertor.ConvertToBCD("305"));
            Assert.AreEqual("1000 0101 0010 ", Convertor.ConvertToBCD("852"));
        }

        [Test]
        public void TestWith4Digits()
        {
            Assert.AreEqual("0011 0000 0101 0001 ", Convertor.ConvertToBCD("3051"));
            Assert.AreEqual("1000 0101 0010 1001 ", Convertor.ConvertToBCD("8529"));
        }


        [Test]
        public void TestWithPositiveSign()
        {
            Assert.AreEqual("0000 0011 0000 0101 ", Convertor.ConvertToBCD("+305"));
            Assert.AreEqual("0000 1000 0101 0010 ", Convertor.ConvertToBCD("+852"));
        }

        [Test]
        public void TestWithNegativeSign()
        {
            Assert.AreEqual("1001 0110 1001 0101 ", Convertor.ConvertToBCD("-305"));
            Assert.AreEqual("1001 0001 0100 1000 ", Convertor.ConvertToBCD("-852"));
        }

        [Test]
        public void TestNegativeSignBiggerThan9000()
        {
            Assert.AreEqual("1000 0111 0111 ", Convertor.ConvertToBCD("-9123"));
        }
    }
}