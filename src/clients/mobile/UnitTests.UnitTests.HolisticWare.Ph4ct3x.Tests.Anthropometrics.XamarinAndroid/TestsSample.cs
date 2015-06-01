using System;
using NUnit.Framework;

namespace UnitTests.UnitTests.HolisticWare.Ph4ct3x.Tests.Anthropometrics.XamarinAndroid
{
	[TestFixture]
	public partial class TestsBodyIndexesBodyAdiposityIndex
	{
		// http://en.wikipedia.org/wiki/Ponderal_index

		[SetUp]
		public void Setup ()
		{
		}

		
		[TearDown]
		public void Tear ()
		{
		}

		[Test]
		public void Pass ()
		{
			Console.WriteLine ("test1");
			Assert.True (true);
		}

		[Test]
		public void Fail ()
		{
			Assert.False (true);
		}

		[Test]
		[Ignore ("another time")]
		public void Ignore ()
		{
			Assert.True (false);
		}

		[Test]
		public void Inconclusive ()
		{
			Assert.Inconclusive ("Inconclusive");
		}
	}
}

