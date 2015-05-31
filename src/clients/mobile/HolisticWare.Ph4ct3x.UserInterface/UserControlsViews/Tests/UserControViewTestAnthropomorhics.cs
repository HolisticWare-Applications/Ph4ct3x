using System;

using Xamarin.Forms;

namespace HolisticWare.Ph4ct3x.UserInterface
{
	public class UserControViewTestAnthropomorhics : ContentPage
	{
		public UserControViewTestAnthropomorhics ()
		{
			Content = new StackLayout { 
				Children = {
						new Label {
							Text = "Hello ContentPage"
						}
				}
			};
		}
	}
}


