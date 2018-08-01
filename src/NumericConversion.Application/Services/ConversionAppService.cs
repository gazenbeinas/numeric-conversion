using System;
using NumericConversion.Application.Interfaces.Factories;
using NumericConversion.Application.Interfaces.Services;

namespace NumericConversion.Application.Services
{
    public class ConversionAppService : IConversionAppService
    {
        readonly IConverterFactory _conversionStrategyFactory;

        public ConversionAppService(
            IConverterFactory conversionStrategyFactory)
        {
            _conversionStrategyFactory = conversionStrategyFactory;
        }

        public object ConvertFromString(
            Guid conversionId, string inputValue) =>
            _conversionStrategyFactory
                .GetConverter(conversionId)
                .ConvertGeneric(inputValue);
    }
}