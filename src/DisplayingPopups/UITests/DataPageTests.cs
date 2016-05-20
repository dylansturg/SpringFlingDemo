using System;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;

namespace UITests
{
	[TestFixture(Platform.iOS)]
	public class DataPageTests
	{
		IApp app;
		Platform platform;

		public DataPageTests(Platform platform)
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

