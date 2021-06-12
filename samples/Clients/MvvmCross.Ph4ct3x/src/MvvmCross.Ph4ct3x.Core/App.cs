using MvvmCross.IoC;
using MvvmCross.ViewModels;
using MvvmCross.Ph4ct3x.Core.ViewModels.Root;

namespace MvvmCross.Ph4ct3x.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<RootViewModel>();
        }
    }
}
