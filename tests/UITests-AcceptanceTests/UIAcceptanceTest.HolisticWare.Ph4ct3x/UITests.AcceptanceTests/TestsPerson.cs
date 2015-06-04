using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UIAcceptanceTest.HolisticWare.Ph4ct3x
{
	[TestFixture (Platform.Android)]
	[TestFixture (Platform.iOS)]
	public class TestsPerson
	{
		IApp app;
		Platform platform;

		public TestsPerson (Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest ()
		{
			app = AppInitializer.StartApp (platform);
		}

		[Test]
		public void AppLaunches ()
		{
			app.Screenshot ("First screen.");

			return;
		}

		[Test]
		public void PagePh4ct3x ()
		{
			app.Screenshot("test01");

			app.Tap(c => c.Marked("About"));

			app.Tap(c => c.Marked("Settings"));

			app.Tap(c => c.Text("Ph4ct3x"));
			AppResult[] results = app.Query( c => c.Marked("ErrorMessagesTextField"));

			return;
		}
	}
}

