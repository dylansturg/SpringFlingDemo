using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

using Xamarin.Forms;

namespace WorkingWithPopups.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate :
	global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate // superclass new in 1.3
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			LoadApplication(new App());  // method is new in 1.3
			var x = typeof(Xamarin.Forms.Themes.DarkThemeResources);
			x = typeof(Xamarin.Forms.Themes.LightThemeResources);
			x = typeof(Xamarin.Forms.Themes.iOS.UnderlineEffect);

#if ENABLE_TEST_CLOUD
			Xamarin.Calabash.Start();
#endif
			return base.FinishedLaunching(app, options);
		}
	}
}

