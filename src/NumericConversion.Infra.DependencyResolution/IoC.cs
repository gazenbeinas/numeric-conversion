using System;
using System.Linq;
using SimpleInjector;

namespace NumericConversion.Infra.DependencyResolution
{
    public class IoC
    {
        static readonly Container Container;

        static IoC()
        {
            Container = new Container();
        }

        public static TService GetInstance<TService>()
            where TService : class =>
            Container.GetInstance<TService>();

        public static void RegisterModule<TModule>()
            where TModule : DependencyModule, new() =>
            new TModule().RegisterDependencies();

        public static void RegisterCollection<TInt>(params Type[] types)
            where TInt : class
        {
            Container.Collection.Register(typeof(TInt), types);

            Container.Register(
                () => Container.GetAllInstances<TInt>().ToArray(),
                Lifestyle.Singleton);
        }

        public static void RegisterSingleton<TInt, TImp>()
            where TImp : class, TInt
            where TInt : class =>
            Container.RegisterSingleton<TInt, TImp>();
    }
}
