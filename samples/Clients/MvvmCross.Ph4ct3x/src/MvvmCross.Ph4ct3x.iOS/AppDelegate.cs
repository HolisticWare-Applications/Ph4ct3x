using Foundation;
using MvvmCross.Forms.Platforms.Ios.Core;

namespace MvvmCross.Ph4ct3x.iOS
{
    [Register(nameof(AppDelegate))]
    public partial class AppDelegate : MvxFormsApplicationDelegate<Setup, Core.App, UI.App>
    {
    }
}
