using System;

namespace HolisticWare.Ph4ct3x.Tests.Anthropometrics
{
	public partial class BodyMassIndex : BodyIndexBase
	{
		public BodyMassIndex ()
		{
		}

		public override double Value
		{
			get
			{
				
				return Double.NaN;
			}
		}

		public double Height
		{
			get;
			set;
		}

		public double Weight
		{
			get;
			set;
		}
	}
}

