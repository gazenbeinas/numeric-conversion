using NumericConversion.Application.Extensions;
using NumericConversion.Application.Interfaces;
using NumericConversion.Application.Models;

namespace NumericConversion.Application.Base
{
    public abstract class BaseConverter<TIn, TOut> : IConverter
    {
        ConverterDetails ConvertDetails { get; }

        protected BaseConverter(ConverterDetails convertDetails)
        {
            ConvertDetails = convertDetails;
        }

        protected abstract TOut Convert(TIn input);


        public ConverterDetails GetConverterDetails() =>
            ConvertDetails;

        public object ConvertGeneric(object input) =>
            Convert(input.ChangeTypeTo<TIn>());
    }
}