using NumericConversion.Application.Factories;
using NumericConversion.Application.Interfaces;
using NumericConversion.Application.Interfaces.Factories;
using NumericConversion.Application.Interfaces.Services;
using NumericConversion.Application.Roman;
using NumericConversion.Application.Services;
using NumericConversion.Infra.DependencyResolution;

namespace NumericConversion.Infra.Bootstrap.Modules
{
    internal class ApplicationDependencyModule : DependencyModule
    {
        public override void RegisterDependencies()
        {
            IoC.RegisterCollection<IConverter>(
                typeof(FromArabicToRomanConverter),
                typeof(FromRomanToArabicConverter));

            IoC.RegisterSingleton<
                IConverterFactory,
                ConverterFactory>();

            IoC.RegisterSingleton<
                IConversionAppService,
                ConversionAppService>();

            IoC.RegisterSingleton<
                IConverterAppService,
                ConverterAppService>();
        }
    }
}