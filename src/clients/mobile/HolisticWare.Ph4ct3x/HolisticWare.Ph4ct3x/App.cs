using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace HolisticWare.Ph4ct3x
{
	public class App : Application // superclass new in 1.3
	{
		public App ()
	    {
	        // The root page of your application
	        MainPage = GetMainPage(); // property new in 1.3

	        return;
	    }

		public Page GetMainPage()
		{
			return new NavigationPage(new About());
		}
	}
}
