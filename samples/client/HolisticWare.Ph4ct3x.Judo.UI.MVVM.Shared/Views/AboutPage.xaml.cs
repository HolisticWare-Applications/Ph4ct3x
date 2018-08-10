using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HolisticWare.Ph4ct3x.Judo.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AboutPage : ContentPage
	{
        partial void HookEvents();

		public AboutPage ()
		{
			InitializeComponent ();

            HookEvents();

            return;
		}
	}
}