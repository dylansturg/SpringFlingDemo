using System;
using Xamarin.Forms;

namespace WorkingWithPopups
{
	public partial class MainPage : TabbedPage
	{
		public MainPage()
		{
			InitializeComponent();

			var alertPage = new NavigationPage(new AlertPage());
			alertPage.Title = "Alerts";
			alertPage.Icon = "csharp.png";

			var actionSheetPage = new NavigationPage(new ActionSheetPage());
			actionSheetPage.Title = "ActionSheets";
			actionSheetPage.Icon = "csharp.png";


			var sampleDataPage = new NavigationPage(new SampleDataPage());
			sampleDataPage.Title = "Data Page";
			sampleDataPage.Icon = "csharp.png";

			Children.Add(alertPage);
			Children.Add(actionSheetPage);
			Children.Add(sampleDataPage);
		}
	}
}

