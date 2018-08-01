using System;

namespace NumericConversion.Application.Models
{
    public class ConverterDetails
    {
        public Guid ConversionId { get; }
        public string ConversionDescription { get; }

        public ConverterDetails(
            Guid conversionId, string conversionDescription)
        {
            ConversionId = conversionId;
            ConversionDescription = conversionDescription;
        }
    }
}