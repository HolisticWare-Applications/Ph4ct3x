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

			Xamarin.Insights.Track("Opened UserControlViewMainMenu");

			return;
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


		public void listViewMenuSpeed_OnItemSelected (object sender, ItemTappedEventArgs args_tapped)
		{
			object item = args_tapped.Item;

			KeyValuePair<string, string> kvp = (KeyValuePair<string, string>)item;

			string type_as_string = kvp.Value;

			Type type = Type.GetType (type_as_string);

			try
			{
				Page page = 
					(Page)Activator.CreateInstance (type)
					// HolisticWare.Mobile.UI.XamarinForms.Activator.CreateElement<Page>(type_as_string)
					;

				this.Navigation.PushAsync (page);
			}
			catch (Exception exc)
			{
				Xamarin.Insights.Report
									(
										exc, 
										Xamarin.Insights.Severity.Critical
									);

				throw;
			}

			return;
		}
	}
}

