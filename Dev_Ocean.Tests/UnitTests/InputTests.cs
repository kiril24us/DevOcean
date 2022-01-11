using Dev_Ocean.Validation;
using DevOcean.Models;
using DevOcean.Services;
using DevOcean_Task;
using Moq;
using System;
using System.IO;
using Xunit;

using static DevOcean.GlobalConstants.TestsMessages;

namespace Dev_Ocean.Tests.UnitTests
{
    public class InputTests
    {
        private Mock<ISpaceshipsService> _spaceshipsServiceMock;
        private Mock<IInputValidation> _inputValidationMock;
        private Input sut;

        public InputTests()
        {
            _spaceshipsServiceMock = new Mock<ISpaceshipsService>();
            _inputValidationMock = new Mock<IInputValidation>();
            sut = new Input(_spaceshipsServiceMock.Object, _inputValidationMock.Object);
        }

        [Fact]
        public void ReadInput_FinalResultMoreThanZero_ReturnsConsoleOutput()
        {
            //arrange
            StringWriter output = SetUpConsole();

            _spaceshipsServiceMock.Setup(x => x.CalculateTax(It.IsAny<Spaceship>(), It.IsAny<int>())).Returns(100);
            _inputValidationMock.Setup(x => x.ValidationSpaceshipType(It.IsAny<string>())).Returns(ValidSpaceshipNameCargo);

            //act
            sut.ReadInput();
            //assert

            Assert.Equal(ExpectedOutputWithFinalResultMoreThanZero, output.ToString());
        }

        [Fact]
        public void ReadInput_FinalResultNegativeNumber_ReturnsConsoleOutput()
        {
            //arrange
            StringWriter output = SetUpConsole();

            _spaceshipsServiceMock.Setup(x => x.CalculateTax(It.IsAny<Spaceship>(), It.IsAny<int>())).Returns(-10);
            _inputValidationMock.Setup(x => x.ValidationSpaceshipType(It.IsAny<string>())).Returns(ValidSpaceshipNameCargo);

            //act
            sut.ReadInput();
            //assert

            Assert.Equal(ExpectedOutputWithFinalResultNegativeNumber, output.ToString());
        }

        private static StringWriter SetUpConsole()
        {
            var output = new StringWriter();
            Console.SetOut(output);

            var input = new StringReader(InputValues);
            Console.SetIn(input);
            return output;
        }
    }
}
