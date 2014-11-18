using NUnit.Framework;
using System;

using Xamarin.UITest;

namespace UItest.HolisticWare.Ph4ct3x.XamarinIOS
{
	[TestFixture ()]
	public class Test
	{
		public string PathToIPA { get; set; }

		[TestFixtureSetUp]
		public void TestFixtureSetup()
		{
		    string currentFile = new Uri(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).LocalPath;
		    System.IO.FileInfo fi = new System.IO.FileInfo(currentFile);
		    string dir = fi.Directory.Parent.Parent.Parent.FullName;
			PathToIPA = System.IO.Path.Combine
										(
										  dir
										, "HolisticWare.Ph4ct3x.iOS"
										, "bin"
										, "iPhoneSimulator"
										, "Debug"
										, "HolisticWarePh4ct3xiOS.app"
										);

			return;
		}
		    

		Xamarin.UITest.iOS.iOSApp _app = null;

		[SetUp]
		public void SetUp()
		{
			// Xamarin.UITest will automatically start the iOS Simulator
			// To ensure that we have a fresh connection to the application, 
			// initialize the _app variable each time a test is run. 
			// Add a SetUp method to the class
		    _app = ConfigureApp.iOS.AppBundle(PathToIPA).StartApp();

		    return;
		}

		[Test ()]
		public void REPL_iOS ()
		{
	       _app.Repl();

	       return;
		}

		//[Test ()]
		public void REPL_Android ()
		{
			string PathToAPK = @"..\..\HolisticWare.Ph4ct3x.Android\bin\Debug\HolisticWare.Ph4ct3x.Android-Signed.apk";

			// Xamarin.UITest will not automatically start the Android Emulator
			Xamarin.UITest.Android.AndroidApp _app = 
					ConfigureApp.Android.ApkFile(PathToAPK)
							// 	If there is more than one device or emulator connected, 
							//		provide the serial ID
							//.DeviceSerial("")
							.StartApp();

	       _app.Repl();

	       return;
		}
	}
}

