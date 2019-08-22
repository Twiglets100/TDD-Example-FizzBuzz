using NUnit.Framework;

namespace FizzBuzzTdd.Test
{
    public class FizzBuzzTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1)]
        [TestCase(2)]
        public void GetValueIfDefaultReturnDefault(int input)
        {
            // Arrange
//            var input = 1;
            // Act
            var output = FizzBuzz.GetValue(input);
            // Assert
            Assert.AreEqual(input.ToString(), output);
        }

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        public void GetValueIfMultipleOf3ReturnFizz(int input)
        {
            var output = FizzBuzz.GetValue(input);
            Assert.AreEqual("Fizz", output);
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        public void GetValueIfMultipleOf5ReturnBuzz(int input)
        {
            var output = FizzBuzz.GetValue(input);
            Assert.AreEqual("Buzz", output);
        }

        [TestCase(15)]
        [TestCase(30)]
        public void GetValueIfMultipleOf3And5ReturnFizzBuzz(int input)
        {
            var output = FizzBuzz.GetValue(input);
            Assert.AreEqual("FizzBuzz", output);
        }
    }
}