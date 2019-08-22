using NUnit.Framework;

namespace FizzBuzzTdd.Test
{
    public class FizzBuzzTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetValueIf1Return1()
        {
            // Arrange
            var input = 1;
            // Act
            var output = FizzBuzz.GetValue(input);
            // Assert
            Assert.AreEqual("1", output);
        }
    }
}