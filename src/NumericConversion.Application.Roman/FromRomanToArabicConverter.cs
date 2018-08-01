using System;
using NumericConversion.Application.Base;
using NumericConversion.Application.Models;

namespace NumericConversion.Application.Roman
{
    public class FromRomanToArabicConverter : BaseConverter<string, int>
    {
        const string GuidKey = "e45c418d-14cd-491b-a227-eff6a54ad362";
        const string Description = "Roman to Arabic";

        public FromRomanToArabicConverter()
            : base(new ConverterDetails(Guid.Parse(GuidKey), Description))
        {
        }

        protected override int Convert(string input)
        {
            return 20;
        }
    }
}