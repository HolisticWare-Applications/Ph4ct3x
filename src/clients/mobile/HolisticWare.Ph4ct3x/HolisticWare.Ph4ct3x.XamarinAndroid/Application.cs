using System;

using Android.App;

namespace HolisticWare.Ph4ct3x.XamarinAndroid
{
	[Application]
	public partial class Application : Android.App.Application
	{
		public Application ()
		{
		}

		public Application (IntPtr handle, Android.Runtime.JniHandleOwnership ownerShip)
			:
			base (handle, ownerShip)
		{

			return;
		}

		public override void OnCreate ()
		{
			// If OnCreate is overridden, the overridden c'tor will also be called.
			base.OnCreate ();

			// partial method:
			//		declaration only
			//			if not defined (call will be removed)
			//			if defined (in other file for this partial class) it will be called/used
			Initialize();

			return;
		}

		private static Android.Content.Context context;

		public static Android.Content.Context Context
		{
			get
			{
				return context;
			}
		}

		static Application()
		{
			context = Android.App.Application.Context;

			return;
		}

	}
}

