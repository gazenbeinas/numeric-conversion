using System;

namespace NumericConversion.Application.Interfaces.Services
{
    public interface IConversionAppService
    {
        object ConvertFromString(Guid conversionId, string inputValue);
    }
}