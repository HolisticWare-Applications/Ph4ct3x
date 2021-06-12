using System;
using Gtk;

namespace Ph4ct3x.App.XamarinForms.GTK
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Gtk.Application.Init();
            Xamarin.Forms.Forms.Init();

            var app = new App();
            var window = new Xamarin.Forms.Platform.GTK.FormsWindow();
            window.LoadApplication(app);
            window.SetApplicationTitle("HolisticWare.Ph4ct3x.Sample.XamarinForms.Blank.GTK");
            window.Show();

            Gtk.Application.Run();

            return;
        }
    }
}
