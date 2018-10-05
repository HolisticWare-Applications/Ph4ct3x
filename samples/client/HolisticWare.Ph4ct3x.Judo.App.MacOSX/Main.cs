using AppKit;

namespace HolisticWare.Ph4ct3x.Judo.MacOSX
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
