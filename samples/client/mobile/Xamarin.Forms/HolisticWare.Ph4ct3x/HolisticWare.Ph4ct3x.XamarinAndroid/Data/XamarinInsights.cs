using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace HolisticWare.Ph4ct3x.XamarinAndroid.Data
{
	public partial class XamarinInsights
	{
		public static string  ApiKey 
		{ 
			get; 
			set; 
		}

		static partial void InitializeDataPrivateSecretSecretReal();

		static XamarinInsights()
		{
			InitializeDataPublicDummy();
			InitializeDataPrivateSecretSecretReal();

			return;
		}

	}
}