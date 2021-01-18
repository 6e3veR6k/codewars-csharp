using NUnit.Framework;
using Base.Starter;

namespace Tests.Base
{
    public class VariableTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Summ_10and20_returned30()
        {
            // assets (could be initialised in setup method for global variables, or settings)
            var first = 10;
            var second = 20;
            var expected = 30;


            // act - call tested method with our parameters
            Variable variable = new Variable();

            var result = variable.GetSumm(first, second);

            // assert - check our prediction
            Assert.AreEqual(expected, result);

        }
    }
}