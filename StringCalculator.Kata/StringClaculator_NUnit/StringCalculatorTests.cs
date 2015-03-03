using NUnit.Framework;

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

    }

}
