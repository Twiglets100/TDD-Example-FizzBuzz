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
        public void GetValueIfMultipleOf3ReturnFizz(int input)
        {
            var output = FizzBuzz.GetValue(input);
            Assert.AreEqual("Fizz", output);
        }
    }
}