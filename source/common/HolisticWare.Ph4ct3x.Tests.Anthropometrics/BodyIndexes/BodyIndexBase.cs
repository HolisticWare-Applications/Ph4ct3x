using System;

namespace HolisticWare.Ph4ct3x.Tests.Anthropometrics
{
	public abstract partial class BodyIndexBase : HolisticWare.Ph4ct3x.Object
	{
		public BodyIndexBase ()
		{
		}

		public Person Person
		{
			get;
			set;
		}

		public virtual double Value
		{
			get
			{
				return Double.NaN;
			}
		}


	}
}

