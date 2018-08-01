using NumericConversion.Infra.Bootstrap.Resolutions;
using NumericConversion.Infra.DependencyResolution;

namespace NumericConversion.ConsoleApp
{
    class Startup
    {
        public static void Configure()
        {
            IoC.RegisterModule<ConsoleAppResolution>();
        }
    }
}