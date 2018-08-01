using System;
using System.Collections.Generic;
using System.Linq;
using NumericConversion.Application.Interfaces;
using NumericConversion.Application.Interfaces.Factories;

namespace NumericConversion.Application.Factories
{
    public class ConverterFactory : IConverterFactory
    {
        readonly IEnumerable<IConverter> _converters;

        public ConverterFactory(IEnumerable<IConverter> converters)
        {
            _converters = converters;
        }

        public IConverter GetConverter(Guid converterId)
        {
            var converterStrategy = _converters
                .FirstOrDefault(x =>
                    x.GetConverterDetails().ConversionId == converterId);

            if (converterStrategy != null)
                return converterStrategy;

            throw new NotSupportedException($"ConversionId {converterId} is not supported");
        }
    }
}