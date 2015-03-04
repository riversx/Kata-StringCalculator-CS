using NUnit.Framework;
using System;

namespace StringClaculator.Kata
{

    [TestFixture]
    public class StringCalculatorTests
    {

        [Test]
        public void Add_StringEmpty_ReturnsZero()
        {
            StringCalculator calc = new StringCalculator();

            int result = calc.Add("");

            Assert.AreEqual(0, result);
        }


        [Test]
        public void Add_NegativeValues_ThrowsExceptionWrong()
        {
            StringCalculator calc = new StringCalculator();

            // Questo funziona !
            try
            {
                calc.Add("-1");
                Assert.Fail("An Exception was expected!");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Negative numbers are not allowed!", ex.Message);
            }

            // Questo funziona !
            Assert.Throws<Exception>(() => calc.Add("-1"));

            // Attenzione questo NON funziona !!!!
            // Fornisce un falso positivo !
            //try
            //{
            //    calc.Add("-1");
            //    Assert.Fail("An Exception was expected!");
            //}
            //catch (Exception)
            //{
            //}

        }

    }

}
