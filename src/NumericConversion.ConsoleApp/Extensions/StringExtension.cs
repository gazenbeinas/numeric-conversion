using System;

namespace NumericConversion.ConsoleApp.Extensions
{
    static class StringExtension
    {
        public static int ToInt(this string value)
        {
            if (int.TryParse(value, out var parsedGuid))
                return parsedGuid;

            throw new ArgumentException("Provided ConvertId must be an integer");
        }
    }
}