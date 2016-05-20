using System;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;

namespace UITests
{
	[TestFixture(Platform.iOS)]
	public class AlertTests
	{
		IApp app;
		Platform platform;

		public AlertTests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
		}


	}
}

