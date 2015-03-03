using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringCalculator_MSTest
{
    [TestClass]
    public class StringCalculatoTests
    {
        private StringCalculator calc;

        [TestInitialize]
        public void Setup()
        {
            calc = new StringCalculator();
        }

        [TestMethod]
        public void Add_StringEmpty_ReturnsZero()
        {
            int result = calc.Add("");

            Assert.AreEqual(0, result);
        }


        [TestMethod]
        public void Add_SingleValue_ReturnsTheValue()
        {
            int result = calc.Add("1");

            Assert.AreEqual(1, result);
        }


        [TestMethod]
        public void Add_TwoValues_ReturnTheSum()
        {
            int result = calc.Add("1,2");

            Assert.AreEqual(3, result);
        }


        [TestMethod]
        public void Add_MultipleValues_ReturnsTheSum()
        {
            int result = calc.Add("1,2,3");

            Assert.AreEqual(6, result);
        }


        [TestMethod]
        public void Add_ValuesWithNewLine_ReturnsTheSum()
        {
            int result = calc.Add("1\n2,3");

            Assert.AreEqual(6, result);
        }


        [TestMethod]
        public void Add_ValuesWithNewLineAndEmptyPart_ThrowsExeption()
        {
            try
            {
                calc.Add("1,\n");
                Assert.Fail("String '1,\n' should throw an exception!");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("System.FormatException", ex.GetType().ToString());
            }
        }


        [TestMethod]
        public void Add_ValuesWithCustomDelimiter_ReturnsTheSum()
        {
            int result = calc.Add("//;\n1;2");

            Assert.AreEqual(3, result);
        }


        [TestMethod]
        public void Add_NegativeValue_ThrowException()
        {
            try
            {
                int result = calc.Add("1,-2");
                Assert.Fail("Exception not thrown.");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("negatives not allowed: -2", ex.Message);
            }
        }


        [TestMethod]
        public void Add_NegativeValues_ThrowException()
        {
            try
            {
                int result = calc.Add("-1,-2");
                Assert.Fail("Exception not thrown.");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("negatives not allowed: -1,-2", ex.Message);
            }
        }



    }
}
