using NUnit.Framework;
using System.Diagnostics;

namespace ElemetaryStage.Tests
{
    public class ProgramTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Sum_10plus20_returned30()
        {
            int a = 10;
            int b = 20;
            int expected = 30;

            var result = Program.Sum(a, b);

            Debug.WriteLine("Ok!");
            Assert.AreEqual(expected, result, $"Are not equal: e --> {expected}, result = {result}");
        }

        [Test]
        public void GetPerimeter_20_10_returned60()
        {
            var firstSide = 10.000001;
            var secondSide = 20.99998;

            var expected = 2 * (firstSide + secondSide);

            var result = Program.GetPerimeter(firstSide, secondSide);


            Assert.AreEqual(expected, result);
        }
    }
}