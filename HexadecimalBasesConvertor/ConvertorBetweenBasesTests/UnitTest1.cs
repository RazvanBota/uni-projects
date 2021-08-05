using NUnit.Framework;
using ConvertorBetweenBases;

namespace ConvertorBetweenBasesTests
{
    public class Tests
    {
        [Test]
        public void ConvertToBaseTenFromLowerBases()
        {
            Assert.AreEqual("2",    Convertor.ConvertToBaseTen("2", 3));
            Assert.AreEqual("2835", Convertor.ConvertToBaseTen("5423", 8));
            Assert.AreEqual("3007", Convertor.ConvertToBaseTen("44012", 5));
        }

        [Test]
        public void ConvertFromBaseTenToLowerBases()
        {
            Assert.AreEqual("212111",                         Convertor.ConvertFromBaseTen("2453", 4));
            Assert.AreEqual("2232",                           Convertor.ConvertFromBaseTen("524", 6));
            Assert.AreEqual("101100111001001100111000100110", Convertor.ConvertFromBaseTen("753192486", 2));
        }

        [Test]
        public void ConvertWithBasesLowerOrEqualToTen()
        {
            Assert.AreEqual("101",               Convertor.ConvertNumber("5", 6, 2));
            Assert.AreEqual("102111",            Convertor.ConvertNumber("1234", 6, 3));
            Assert.AreEqual("11000000111001101", Convertor.ConvertNumber("98765", 10, 2));
        }

        [Test]
        public void ConvertFromHexadecimalToBaseTen()
        {
            Assert.AreEqual("2138", Convertor.ConvertToBaseTen("85A", 16));
            Assert.AreEqual("44",   Convertor.ConvertToBaseTen("2C", 16));
            Assert.AreEqual("1533", Convertor.ConvertToBaseTen("5FD", 16));
        }

        [Test]
        public void ConvertFromBaseTenToHexadecimal()
        {
            Assert.AreEqual("85A", Convertor.ConvertFromBaseTen("2138", 16));
            Assert.AreEqual("2C",  Convertor.ConvertFromBaseTen("44", 16));
            Assert.AreEqual("5FD", Convertor.ConvertFromBaseTen("1533", 16));
        }

        [Test]
        public void ConvertBetweenHexadecimalBases()
        {
            Assert.AreEqual("2EB",  Convertor.ConvertNumber("456", 13, 16));
            Assert.AreEqual("6993", Convertor.ConvertNumber("2ABC", 15, 11));
            Assert.AreEqual("16C7", Convertor.ConvertNumber("FFF", 16, 14));
        }

        [Test]
        public void ConvertNumberWithFixedCommaToBaseTen()
        {
            Assert.AreEqual("3.703125",  Convertor.ConvertToBaseTen("11.101101", 2));
            Assert.AreEqual("2.76",      Convertor.ConvertToBaseTen("2.34", 5));
            Assert.AreEqual("42.246094", Convertor.ConvertToBaseTen("2A.3F", 16));
        }

        [Test]
        public void ConvertNumberWithFixedCommaFromBaseTenToNewBase()
        {
            Assert.AreEqual("2.213", Convertor.ConvertFromBaseTen("2.47", 5));
            Assert.AreEqual("5.212", Convertor.ConvertFromBaseTen("5.27", 8));
            Assert.AreEqual("4.3EB", Convertor.ConvertFromBaseTen("4.245", 16));
        }

        [Test]
        public void ConvertNumberWithComma()
        {
            Assert.AreEqual("1A4.912",      Convertor.ConvertNumber("457.546", 8, 13));
            Assert.AreEqual("100.11010101", Convertor.ConvertNumber("4.AAC", 13, 2));
            Assert.AreEqual("1.662",       Convertor.ConvertNumber("1.2536", 7, 16));
        }
    }
}