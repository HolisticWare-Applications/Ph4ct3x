using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace HolisticWare.Ph4ct3x.UserInterface
{
	public partial class UserControlViewMainMenu : ContentView
	{
		public UserControlViewMainMenu ()
		{
			InitializeComponent ();
		}

		protected async void buttonUserView_Clicked (object sender, EventArgs ea)
		{
			await this.Navigation.PushAsync(new PageDataPersonal());

			return;
		}

		protected async void buttonUserAdd_Clicked (object sender, EventArgs ea)
		{
			await this.Navigation.PushAsync(new PageDataPersonal());

			return;
		}
	}
}

