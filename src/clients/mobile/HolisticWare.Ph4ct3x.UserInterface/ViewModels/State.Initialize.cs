using System;
using System.Collections.ObjectModel;

namespace HolisticWare.Ph4ct3x
{
	public partial class State : HolisticWare.Ph4ct3x.Object
	{

		static ObservableCollection<User> LoadUsers ()
		{
			ObservableCollection<User> users =  new ObservableCollection<User>()
			{
				new User()
				{
					UserName = "vyeko",
					NameFirstGiven = "J",
					NameSecondFamily = "Z",
					DateOfBirth = new DateTime(2006, 6, 5),
					Gender = Gender.Female
				}
			,
				new User()
				{
					UserName = "zunzo",
					NameFirstGiven = "N",
					NameSecondFamily = "Z",
					DateOfBirth = new DateTime(2004, 9, 19),
					Gender = Gender.Female
				}
			,
				new User()
				{
					UserName = "jaja",
					NameFirstGiven = "L",
					NameSecondFamily = "Z",
					DateOfBirth = new DateTime(2001, 9, 01),
					Gender = Gender.Female
				}
			,
				new User()
				{
					UserName = "chooki",
					NameFirstGiven = "S",
					NameSecondFamily = "pZ",
					DateOfBirth = new DateTime(1970, 10, 28),
					Gender = Gender.Female
				}
			,
				new User()
				{
					UserName = "moljac",
					NameFirstGiven = "M",
					NameSecondFamily = "Z",
					DateOfBirth = new DateTime(1968, 9, 24),
					Gender = Gender.Female
				}

			};


			return users;			
		}
	}
}

