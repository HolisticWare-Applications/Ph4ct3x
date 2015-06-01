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
	public class TestsBodyIndexes
	{
		IApp app;
		Platform platform;

		public TestsBodyIndexes (Platform platform)
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
	}
}

