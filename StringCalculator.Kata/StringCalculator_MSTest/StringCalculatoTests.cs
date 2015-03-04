using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
            Exception expectedException = null;
            try
            {
                calc.Add("1,\n");
            }
            catch (Exception ex)
            {
                expectedException = ex;
            }
            Assert.IsNotNull(expectedException);
            Assert.AreEqual(typeof(System.FormatException), expectedException.GetType());
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
            Exception expectedException = null;
            try
            {
                calc.Add("1,-2");
            }
            catch (Exception ex)
            {
                expectedException = ex;
            }
            Assert.IsNotNull(expectedException);
            Assert.AreEqual("negatives not allowed: -2", expectedException.Message);
        }


        [TestMethod]
        public void Add_NegativeValues_ThrowException()
        {
            Exception expectedException = null;
            try 
            {
                calc.Add("-1,-2");
            }
            catch (Exception ex)
            {
                expectedException = ex;
            }
            Assert.IsNotNull(expectedException);
            Assert.AreEqual("negatives not allowed: -1,-2", expectedException.Message);
        }



    }
}
