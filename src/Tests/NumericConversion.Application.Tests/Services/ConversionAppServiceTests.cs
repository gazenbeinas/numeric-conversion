using System;
using Moq;
using NumericConversion.Application.Interfaces;
using NumericConversion.Application.Interfaces.Factories;
using NumericConversion.Application.Services;
using Xunit;

namespace NumericConversion.Application.Tests.Services
{
    public class ConversionAppServiceTests
    {
        readonly ConversionAppService _conversionAppService;

        readonly Mock<IConverterFactory> _converterFactoryMock;
        readonly Mock<IConverter> _converterMock;

        public ConversionAppServiceTests()
        {
            _converterFactoryMock = new Mock<IConverterFactory>();
            _converterMock = new Mock<IConverter>();

            _conversionAppService = new ConversionAppService(
                _converterFactoryMock.Object);
        }

        [Fact]
        public void ConvertFromString_GetsConverter_CallsConvertGeneric_Returns()
        {
            var testingGuid = Guid.NewGuid();
            var input = Guid.NewGuid().ToString();
            var expectedOutput = Guid.NewGuid();

            _converterFactoryMock.Setup(x => x.GetConverter(testingGuid))
                .Returns(_converterMock.Object);

            _converterMock.Setup(x => x.ConvertGeneric(input))
                .Returns(expectedOutput);

            var actualOutput = _conversionAppService
                .ConvertFromString(testingGuid, input);

            Assert.Equal(expectedOutput, actualOutput);

            _converterFactoryMock.Verify(x =>
                x.GetConverter(testingGuid), Times.Once);

            _converterMock.Verify(x =>
                x.ConvertGeneric(input), Times.Once);
        }
    }
}