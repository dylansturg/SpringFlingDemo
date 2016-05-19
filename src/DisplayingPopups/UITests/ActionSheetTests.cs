using System;
using NUnit.Framework;
using Xamarin.UITest;

namespace UITests
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class ActionSheetTests
	{
		IApp app;
		Platform platform;

		public ActionSheetTests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
		}

		[Test]
		public void ActionSheetPage_Simple_ActionSheet_Button()
		{
			app.Tap(x => x.Marked("ActionSheets"));
			app.Screenshot("Open ActionSheets tab");
			app.Tap(x => x.Marked("ActionSheet Simple"));
			app.Screenshot("Open Simple ActionSheet");

			app.WaitForElement("Email");
			app.WaitForElement("Twitter");
			app.WaitForElement("Facebook");

			app.Tap(x => x.Marked("Email"));
			app.Screenshot("Closed Simple Action Sheet");
		}

		[Test]
		public void ActionSheetPage_ActionSheet_With_Delete()
		{
			app.Tap(x => x.Marked("ActionSheets"));
			app.Screenshot("Tapped on view with class: UITabBarSwappableImageView");
			app.Tap(x => x.Marked("ActionSheet Cancel/Delete"));
			app.Screenshot("Tapped on view with class: UIButtonLabel marked: ActionSheet Cancel/Delete");

			app.WaitForElement("Delete");
			app.WaitForElement("Email");

			app.Tap(x => x.Marked("Photo Roll"));
			app.Screenshot("Tapped on view with class: _UIAlertControllerActionView marked: Photo Roll");
		}
	}
}

