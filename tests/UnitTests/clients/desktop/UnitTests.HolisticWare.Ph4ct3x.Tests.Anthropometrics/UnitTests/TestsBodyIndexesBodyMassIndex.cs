using System;
using NUnit.Framework;

using HolisticWare.Ph4ct3x.Tests.Anthropometrics;

namespace UnitTests.HolisticWare.Ph4ct3x.Tests.Anthropometrics
{
	[TestFixture ()]
	public partial class TestsBodyIndexesBodyMassIndex
	{
		// http://en.wikipedia.org/wiki/Body_mass_index

		Person person = null;

		[SetUp]
		public void Setup ()
		{
			person =  new Person()
			{
				NameFirstGiven = "ood-loo"
			,	NameSecondFamily = "chaknoot"
			,	Gender = global::HolisticWare.Ph4ct3x.Gender.Female
			,	Weight = 93.0
			, 	Height = 180
			,	WaistCircumference = 100
			};

			return;
		}

		
		[TearDown]
		public void Tear ()
		{
		}

		[Test]
		public void BodymassIndex ()
		{

			return;
		}


	}
}

