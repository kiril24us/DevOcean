using Dev_Ocean.Validation;
using System;
using System.IO;
using Xunit;

using static DevOcean.GlobalConstants.TestsMessages;

namespace Dev_Ocean.Tests.UnitTests
{
    public class InputValidationTests
    {       
        private InputValidation sut;

        public InputValidationTests()
        {
            sut = new InputValidation();
        }

        [Fact]
        public void ValidationSpaceshipType_InvalidInputAsParameterAfterThatValidParameterCargo_ReturnsValidParameter()
        {
            //arrange
            var input = new StringReader(ValidSpaceshipNameCargo);
            Console.SetIn(input);

            //act
            var result = sut.ValidationSpaceshipType(InvalidSpaceshipName);

            //assert
            Assert.Equal(ValidSpaceshipNameCargo, result);
        }

        [Fact]
        public void ValidationSpaceshipType_InvalidInputAsParameterAfterThatValidParameterFamily_ReturnsValidParameter()
        {
            //arrange
            var input = new StringReader(ValidSpaceshipNameFamily);
            Console.SetIn(input);

            //act
            var result = sut.ValidationSpaceshipType(WhiteSpaceAsInput);

            //assert
            Assert.Equal(ValidSpaceshipNameFamily, result);
        }

        [Fact]
        public void ValidationTheInputNumber_InvalidInputZeroAsParameterAfterThatValidParameter_ReturnsValidParameter()
        {
            //arrange
            SetUpConsoleReadline();

            //act
            var result = sut.ValidationTheInputNumber(ZeroAsInput);

            //assert
            Assert.Equal(100, result);
        }

        [Fact]
        public void ValidationTheInputNumber_InvalidInputNegativeNumberAsParameterAfterThatValidParameter_ReturnsValidParameter()
        {
            //arrange
            SetUpConsoleReadline();

            //act
            var result = sut.ValidationTheInputNumber(NegativeNumberAsInput);

            //assert
            Assert.Equal(100, result);
        }

        [Fact]
        public void ValidationTheInputNumber_InvalidInputStringAsParameterAfterThatValidParameter_ReturnsValidParameter()
        {
            //arrange
            SetUpConsoleReadline();

            //act
            var result = sut.ValidationTheInputNumber(StringAsInput);

            //assert
            Assert.Equal(100, result);
        }

        [Fact]
        public void ValidationTheInputNumber_ValidInputAsParameterAfterThatSameValidParameter_ReturnsValidParameter()
        {
            //act
            var result = sut.ValidationTheInputNumber(ValidInputNumber);

            //assert
            Assert.Equal(100, result);
        }

        private static void SetUpConsoleReadline()
        {
            var input = new StringReader(ValidInputNumber);
            Console.SetIn(input);
        }
    }
}
