using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UIAcceptanceTest.HolisticWare.Ph4ct3x
{
	public class AppInitializer
	{
		static string ios_ipa = "/Users/moljac/Projects/HolisticWare/Ph4ct3x/src/clients/mobile/HolisticWare.Ph4ct3x/HolisticWare.Ph4ct3x.iOS/bin/iPhoneSimulator/Debug/HolisticWarePh4ct3xiOS.app";
		static string android_apk = "/Users/moljac/Projects/HolisticWare/Ph4ct3x/src/clients/mobile/HolisticWare.Ph4ct3x/HolisticWare.Ph4ct3x.Droid/bin/Release/HolisticWare.Ph4ct3x.Droid.apk";

		static IApp app = null;

		public static IApp StartApp (Platform platform)
		{
			// TODO: If the iOS or Android app being tested is included in the solution 
			// then open the Unit Tests window, right click Test Apps, select Add App Project
			// and select the app projects that should be tested.
			if (platform == Platform.Android)
			{
				app = ConfigureApp
					.Android
					// TODO: Update this path to point to your Android app and uncomment the
					// code if the app is not included in the solution.
					.ApkFile (android_apk)
					.StartApp ();

				app.Repl();

				return app;
			}

			app = ConfigureApp
				.iOS
				// TODO: Update this path to point to your iOS app and uncomment the
				// code if the app is not included in the solution.
				.AppBundle (ios_ipa)
				.StartApp ();

				app.Repl();

				return app;
		}
	}
}

