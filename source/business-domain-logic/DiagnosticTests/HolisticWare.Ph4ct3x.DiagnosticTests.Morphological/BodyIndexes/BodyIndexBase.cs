using System;

namespace HolisticWare.Ph4ct3x.DiagnosticTests.Morphological.BodyIndices
{
	public abstract partial class BodyIndexBase
        :
        MorphologicalMeasurement
        // HolisticWare.Ph4ct3x.Object
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

