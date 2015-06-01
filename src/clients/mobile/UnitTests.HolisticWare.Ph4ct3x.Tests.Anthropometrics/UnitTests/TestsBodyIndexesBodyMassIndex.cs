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
				NameFirstGiven = "aaaolooo"
			,	NameSecondFamily = "mamoyebach"
			,	DateOfBirth = new DateTime(1968,9,24)
			,	Gender = global::HolisticWare.Ph4ct3x.Gender.Female
			};

			return;
		}

		
		[TearDown]
		public void Tear ()
		{
		}

		[Test]
		public void Age ()
		{
			double age = person.AgeinYears();

			Assert.Greater(age, 46);

			TimeSpan ts_age = person.Age();

			Assert.Greater(ts_age, new TimeSpan(46 * 365, 0, 0));

			return;
		}

	}
}

