using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HolisticWare.Ph4ct3x.Judo.Views
{
	public partial class AboutPage
	{
		partial void HookEvents ()
		{
            buttonSearchPage.Clicked += ButtonSearchPage_Clicked;                            

            return;
		}

        protected void ButtonSearchPage_Clicked (object sender, EventArgs e) 
        {
            Navigation.PushAsync(new SearchJudoka());

            return;
        }
	}
}