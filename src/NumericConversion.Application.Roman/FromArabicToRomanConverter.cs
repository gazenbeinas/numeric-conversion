using System;
using NumericConversion.Application.Base;
using NumericConversion.Application.Models;

namespace NumericConversion.Application.Roman
{
    public class FromArabicToRomanConverter : BaseConverter<int,string>
    {
        const string GuidKey = "6a593804-1443-433c-ad64-2b918861f63d";
        const string Description = "Arabic to Roman";

        public FromArabicToRomanConverter()
            : base(new ConverterDetails(Guid.Parse(GuidKey), Description))
        {
        }

        protected override string Convert(int input)
        {
            return "XX";
        }
    }
}