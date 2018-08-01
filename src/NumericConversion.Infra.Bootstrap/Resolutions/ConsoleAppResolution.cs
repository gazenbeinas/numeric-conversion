using NumericConversion.Infra.Bootstrap.Modules;
using NumericConversion.Infra.DependencyResolution;

namespace NumericConversion.Infra.Bootstrap.Resolutions
{
    public class ConsoleAppResolution : DependencyModule
    {
        public override void RegisterDependencies()
        {
            IoC.RegisterModule<ApplicationDependencyModule>();
        }
    }
}