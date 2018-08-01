using System;
using System.Collections.ObjectModel;
using System.Linq;
using NumericConversion.Application.Models;

namespace NumericConversion.ConsoleApp.Helpers
{
    class OutputHelper
    {
        public static string SystemTitle =>
            "Numeric Conversion System";

        public static string AskForConverterIdMessage =>
            "Provide a conversion id: ";

        public static string AskForInputValueMessage =>
            "Type the input value: ";

        public static string FormatResultMessage(object result) =>
            $"Result: {result}";

        public static string FormatErrorMessage(Exception ex) =>
            $"Error: {ex.Message}";

        public static string AskIfUserWantToRunAgainMessage() =>
            "\nPress enter to run again or any other key to leave";

        public static string FormatMenuViaConversionDetails(ReadOnlyCollection<ConverterDetails> details) =>
            string.Join("\n", details.Select(x =>
                $"{x.ConversionDescription} -> {details.IndexOf(x)}"));
    }
}