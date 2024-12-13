namespace FizzBuzzLib.Tests
{
    using FluentAssertions;
    using Xunit;

    public class DemoMethodTests
    {
        #region Old Test Cases
        //[Fact]
        //public void FizzBuzzifyAnInt_Input3_ReturnFizz()
        //{
        //    // arrange
        //    var fizzBuzzClass = new FizzBuzz();

        //    // act
        //    var output = fizzBuzzClass.FizzBuzzifyAnInt(3);

        //    //assert
        //    output.Should().Be("Fizz");
        //}
        //[Fact]
        //public void FizzBuzzifyAnInt_Input5_ReturnBuzz()
        //{
        //    // arrange
        //    var fizzBuzzClass = new FizzBuzz();

        //    // act
        //    var output = fizzBuzzClass.FizzBuzzifyAnInt(5);

        //    //assert
        //    output.Should().Be("Buzz");
        //}
        //[Fact]
        //public void FizzBuzzifyAnInt_Input15_ReturnFizzBuzz()
        //{
        //    // arrange
        //    var fizzBuzzClass = new FizzBuzz();

        //    // act
        //    var output = fizzBuzzClass.FizzBuzzifyAnInt(15);

        //    //assert
        //    output.Should().Be("FizzBuzz");
        //}
        //[Fact]
        //public void FizzBuzzifyAnInt_Input17_Return17()
        //{
        //    // arrange
        //    var fizzBuzzClass = new FizzBuzz();

        //    // act
        //    var output = fizzBuzzClass.FizzBuzzifyAnInt(17);

        //    //assert
        //    output.Should().Be("17");
        //}
        //#endregion

        //#region Test Cases For FizzBuzzValuesForRange
        ////Just for fun
        //[Fact]
        //public void FizzBuzzValuesForRange_Input3_ReturnFizz()
        //{
        //    // arrange
        //    var fizzBuzzClass = new FizzBuzz();

        //    // act
        //    var output = fizzBuzzClass.FizzBuzzValuesForRange(1,10);

        //    //assert
        //    output.Should().ContainInOrder("1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz");
        //}
        #endregion

        #region Test Cases For Extended Task
        [Fact]
        public void FizzBuzzValuesForRange_InputDefaultDict_ReturnSequence()
        {
            // arrange
            var fizzBuzzClass = new FizzBuzz();

            // act
            var output = fizzBuzzClass.FizzBuzzValuesForRange(1, 10);

            //assert
            output.Should().ContainInOrder("1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz");
        }
        [Fact]
        public void FizzBuzzValuesForRange_InputDict2Even_ReturnSequence()
        {
            // arrange
            var fizzBuzzClass = new FizzBuzz();

            // act
            fizzBuzzClass.ReplacementPairs.Clear(); //Clearing default values
            fizzBuzzClass.ReplacementPairs.Add(2, "Even"); //Adding new values to dictionary
            var output = fizzBuzzClass.FizzBuzzValuesForRange(1, 10);
            
            //assert
            output.Should().ContainInOrder("1", "Even", "3", "Even", "5", "Even", "7", "Even", "9", "Even");
        }
        [Fact]
        public void FizzBuzzValuesForRange_Input2Quack5Honk_ReturnSequence()
        {
            // arrange
            var fizzBuzzClass = new FizzBuzz();

            // act
            fizzBuzzClass.ReplacementPairs.Clear(); //Clearing default values
            fizzBuzzClass.ReplacementPairs.Add(2, "Quack");//Adding new values to dictionary
            fizzBuzzClass.ReplacementPairs.Add(5, "Honk");
            var output = fizzBuzzClass.FizzBuzzValuesForRange(1, 10);

            //assert
            output.Should().ContainInOrder("1", "Quack", "3", "Quack", "Honk", "Quack", "7", "Quack", "9", "QuackHonk");
        }
        #endregion
    }
}
