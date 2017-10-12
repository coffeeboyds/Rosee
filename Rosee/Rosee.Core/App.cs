using MvvmCross.Binding.Parse.Binding.Lang;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;
using Rosee.Core.PlatformDependent;
using Rosee.Core.ViewModels;

namespace Rosee.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            Mvx.RegisterType<IMvxLanguageBindingParser, CustomLanguageBindingParser>();
            
            //Mvx.ConstructAndRegisterSingleton<IQuery, Query>();
            Mvx.ConstructAndRegisterSingleton<IPlatformDependent, PlatformDependentCode>();

            Mvx.RegisterSingleton<IMvxAppStart>(new MvxNavigationServiceAppStart<LoginViewModel>(Mvx.Resolve<IMvxNavigationService>()));
        }
    }
}
