using System;
using Terminal.Gui.Forms;
using Xamarin.Forms;

namespace Demo.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Application.Init();
            Forms.Init();
            var app = new App();
            var window = new FormsWindow("Xamarin.Forms gui.cs Backend");
            //window.LoadApplication(app);
            //Application.Run();
        }
    }
}
