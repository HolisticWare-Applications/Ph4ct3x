using AppKit;

namespace Ph4ct3x.App.XamarinForms.MacOSX
{
    static class MainClass
    {
        static void Main(string[] args)
        {
            NSApplication.Init();
            NSApplication.SharedApplication.Delegate = new AppDelegate();
            NSApplication.Main(args);

            return;
        }
    }
}
