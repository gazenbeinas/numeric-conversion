using System.Collections.Generic;
using NumericConversion.Application.Models;

namespace NumericConversion.Application.Interfaces.Services
{
    public interface IConverterAppService
    {
        List<ConverterDetails> GetConversionDetailsAvailable();
    }
}