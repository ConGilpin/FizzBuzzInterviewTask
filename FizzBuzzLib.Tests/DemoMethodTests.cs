namespace FizzBuzzLib.Tests
{
    using FluentAssertions;
    using Xunit;

    public class DemoMethodTests
    {
        #region Test Cases For FizzBuzzifyAnInt
        [Fact]
        public void FizzBuzzifyAnInt_Input3_ReturnFizz()
        {
            // arrange
            var fizzBuzzClass = new FizzBuzz();

            // act
            var output = fizzBuzzClass.FizzBuzzifyAnInt(3);

            //assert
            output.Should().Be("Fizz");
        }
        [Fact]
        public void FizzBuzzifyAnInt_Input5_ReturnBuzz()
        {
            // arrange
            var fizzBuzzClass = new FizzBuzz();

            // act
            var output = fizzBuzzClass.FizzBuzzifyAnInt(5);

            //assert
            output.Should().Be("Buzz");
        }
        [Fact]
        public void FizzBuzzifyAnInt_Input15_ReturnFizzBuzz()
        {
            // arrange
            var fizzBuzzClass = new FizzBuzz();

            // act
            var output = fizzBuzzClass.FizzBuzzifyAnInt(15);

            //assert
            output.Should().Be("FizzBuzz");
        }
        [Fact]
        public void FizzBuzzifyAnInt_Input17_Return17()
        {
            // arrange
            var fizzBuzzClass = new FizzBuzz();

            // act
            var output = fizzBuzzClass.FizzBuzzifyAnInt(17);

            //assert
            output.Should().Be("17");
        }
        #endregion

        #region Test Cases For FizzBuzzValuesForRange
        [Fact]
        public void FizzBuzzValuesForRange_Input3_ReturnFizz()
        {
            // arrange
            var fizzBuzzClass = new FizzBuzz();

            // act
            var output = fizzBuzzClass.FizzBuzzValuesForRange(1,10);

            //assert
            output.Should().ContainInOrder("1", "2", "Fizz", "4", "“Buzz ", "Fizz", "7", "8", "Fizz", "Buzz");
        }
        #endregion
    }
}
