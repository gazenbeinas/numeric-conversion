using System;
using System.Collections.Generic;
using NumericConversion.Application.Interfaces.Services;
using NumericConversion.Application.Models;
using NumericConversion.ConsoleApp.Extensions;
using NumericConversion.ConsoleApp.Helpers;

namespace NumericConversion.ConsoleApp.Services
{
    public class ConversionService
    {
        readonly IConversionAppService _conversionAppService;
        readonly IConverterAppService _convertersAppService;

        public ConversionService(
            IConversionAppService conversionAppService,
            IConverterAppService convertersAppService)
        {
            _conversionAppService = conversionAppService;
            _convertersAppService = convertersAppService;
        }

        public void Execute()
        {
            var availableConverterDetails = _convertersAppService
                .GetConversionDetailsAvailable()
                .AsReadOnly();

            do
            {
                Console.Clear();
                Console.Title = OutputHelper.SystemTitle;

                try
                {
                    Console.WriteLine(OutputHelper.SystemTitle);
                    Console.WriteLine(OutputHelper
                        .FormatMenuViaConversionDetails(
                            availableConverterDetails));

                    var converterId = GetConverterIdFromIndex(
                        AskForConverterIndex(),
                        availableConverterDetails);

                    var inputValue = AskForInputValue();

                    var result = _conversionAppService
                        .ConvertFromString(converterId, inputValue);

                    Console.WriteLine(OutputHelper.FormatResultMessage(result));
                }
                catch (Exception e)
                {
                    Console.WriteLine(OutputHelper.FormatErrorMessage(e));
                }

                Console.WriteLine(OutputHelper.AskIfUserWantToRunAgainMessage());
            } while (UserDecideToContinue());
        }

        static int AskForConverterIndex()
        {
            Console.Write(OutputHelper.AskForConverterIdMessage);

            return Console.ReadLine().ToInt();
        }

        static Guid GetConverterIdFromIndex(
            int index, IReadOnlyList<ConverterDetails> details)
        {
            if (details.Count <= index)
                throw new ArgumentException("Given converter id is not valid");

            return details[index].ConversionId;
        }

        static string AskForInputValue()
        {
            Console.Write(OutputHelper.AskForInputValueMessage);

            var inputValue = Console.ReadLine()?.Trim();
            return inputValue;
        }

        static bool UserDecideToContinue() =>
            Console.ReadKey().Key == ConsoleKey.Enter;
    }
}