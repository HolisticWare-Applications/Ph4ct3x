using System;


namespace HolisticWare.Ph4ct3x.XamarinAndroid
{
	public partial class Application 
	{
		private void Initialize()
		{
			string apikey = HolisticWare.Ph4ct3x.XamarinAndroid.Data.XamarinInsights.ApiKey;
			Android.Content.Context c = HolisticWare.Ph4ct3x.XamarinAndroid.Application.Context;

			Xamarin.Insights.Initialize(apikey, c);

			return;
		}
	}
}