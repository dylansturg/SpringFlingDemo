using System;
using Xamarin.Forms;

namespace WorkingWithPopups
{
	public partial class MainPage : TabbedPage
	{
		public MainPage ()
		{
			InitializeComponent ();

			var alertPage = new AlertPage();
			alertPage.Title = "Alerts";
			alertPage.Icon = "csharp.png";
			var actionSheetPage = new ActionSheetPage();
			actionSheetPage.Title = "Action Sheets";
			actionSheetPage.Icon = "csharp.png";
			var navigationPage = new NavigationPage();
			var sampleDataPage = new SampleDataPage();
			navigationPage.PushAsync(sampleDataPage);
			navigationPage.Title = "Data Page";
			navigationPage.Icon = "csharp.png";


			Children.Add(alertPage);
			Children.Add(actionSheetPage);
			Children.Add(navigationPage);
		}
	}
}

