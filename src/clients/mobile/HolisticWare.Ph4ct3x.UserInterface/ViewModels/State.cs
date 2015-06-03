using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using HolisticWare.Ph4ct3x.Tests.Anthropometrics;

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


		public static Dictionary<string,string> MenuSpeed
		{
			get
			{
				return menu_speed;
			}
			set
			{
				menu_speed = value;
			}
		}

		public static ObservableCollection<BodyIndexBase> BodyIndexes
		{
			get
			{
				return body_indexes;
			}
			set
			{
				body_indexes = value;
			}
		}
	}
}

