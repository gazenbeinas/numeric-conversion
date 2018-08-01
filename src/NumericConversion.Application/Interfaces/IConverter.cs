using NumericConversion.Application.Models;

namespace NumericConversion.Application.Interfaces
{
    public interface IConverter
    {
        ConverterDetails GetConverterDetails();

        object ConvertGeneric(object input);
    }
}