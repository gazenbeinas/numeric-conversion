using NumericConversion.ConsoleApp.Services;
using NumericConversion.Infra.DependencyResolution;

namespace NumericConversion.ConsoleApp
{
    class Program
    {
        static void Main()
        {
            Startup.Configure();

            IoC.GetInstance<ConversionService>().Execute();
        }
    }
}
