using System.Collections.Generic;
using System.Linq;
using NumericConversion.Application.Interfaces;
using NumericConversion.Application.Interfaces.Services;
using NumericConversion.Application.Models;

namespace NumericConversion.Application.Services
{
    public class ConverterAppService : IConverterAppService
    {
        readonly IEnumerable<IConverter> _conversions;

        public ConverterAppService(
            IEnumerable<IConverter> conversions)
        {
            _conversions = conversions;
        }

        public List<ConverterDetails> GetConversionDetailsAvailable() =>
            _conversions?.Select(x => x.GetConverterDetails()).ToList();
    }
}