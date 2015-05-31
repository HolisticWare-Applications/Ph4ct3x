using System;
using System.Collections.ObjectModel;

namespace HolisticWare.Ph4ct3x
{
	public partial class State : HolisticWare.Ph4ct3x.Object
	{
		static State ()
		{
			Users = LoadUsers();

			return;
		}


		public State ()
		{
		}

		public User User
		{
			get;
			set;
		}

		public static ObservableCollection<User> Users
		{
			get;
			set;
		}
	}
}

