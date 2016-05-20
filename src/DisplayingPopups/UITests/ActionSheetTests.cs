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
			app.Screenshot("Opened Action Sheet Tab");
			app.Tap(x => x.Marked("ActionSheet Cancel/Delete"));
			app.Screenshot("Opened Action Sheet with Delete");

			app.WaitForElement("Delete");
			app.WaitForElement("Email");

			app.Tap(x => x.Marked("Photo Roll"));
			app.Screenshot("Closed Action Sheet");
		}
	}
}

