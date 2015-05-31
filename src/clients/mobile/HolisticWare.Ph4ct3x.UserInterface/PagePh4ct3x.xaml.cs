	using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HolisticWare.Ph4ct3x.UserInterface
{
	public partial class PagePh4ct3x : TabbedPage
	{
		public PagePh4ct3x ()
		{
			InitializeComponent ();
		}

		protected async void buttonUserView_Clicked (object sender, EventArgs ea)
		{
			await this.Navigation.PushAsync(new PageDataPersonal());

			return;
		}
	}
}

