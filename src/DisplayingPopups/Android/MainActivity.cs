using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Graphics;
using Android.Graphics.Drawables;

using Xamarin.Forms.Platform.Android;

namespace WorkingWithPopups.Android
{

	[Activity(Label = "WorkingWithPopups.Android.Android", Icon = "@drawable/ic_launcher", MainLauncher = true,
		ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity :
	global::Xamarin.Forms.Platform.Android.FormsApplicationActivity // superclass new in 1.3
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			global::Xamarin.Forms.Forms.Init(this, bundle);

			LoadApplication(new App()); // method is new in 1.3

			if (ActionBar != null)
			{
				var clearIcon = new ColorDrawable();
				clearIcon.Color = Color.Transparent;
				ActionBar.SetIcon(clearIcon);
			}
		}
	}


}

