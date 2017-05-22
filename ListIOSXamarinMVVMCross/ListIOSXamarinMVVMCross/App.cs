using ListIOSXamarinMVVMCross.ViewModels;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;

namespace ListIOSXamarinMVVMCross
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            //CreatableTypes()
            //    .EndingWith("Service")
            //    .AsInterfaces()
            //    .RegisterAsLazySingleton();
            //RegisterAppStart<ViewModels.ListViewModel>();

            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<ListViewModel>());
        }
    }
}
