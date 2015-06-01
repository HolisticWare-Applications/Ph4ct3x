using NUnit.Framework;
using System;
using HolisticWare.Ph4ct3x.Tests.Anthropometrics;

namespace UnitTests.HolisticWare.Ph4ct3x.Tests.Anthropometrics
{
	[TestFixture ()]
	public partial class TestsPerson
	{
		Person person = null;

		[SetUp]
		public void Setup ()
		{
			person =  new Person()
			{
			  
			};

			return;
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

