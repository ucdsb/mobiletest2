using System;
using Xamarin.Forms;
using MobileTest1.Views;
using Xamarin.Forms.Xaml;

using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace MobileTest1
{
	public partial class App : Application
	{
		
		public App ()
		{
			InitializeComponent();

			MainPage = new MainPage();
		}

		protected override void OnStart ()
		{
            // Handle when your app starts e
            AppCenter.Start("android=b2365228-c7dd-48f4-a8ba-4727e0da1fe1;" +
                  "ios=b1f9fe31-39d4-4e12-880e-bdd8e707957e;",
                  typeof(Analytics), typeof(Crashes));
            AppCenter.Start("android=b2365228-c7dd-48f4-a8ba-4727e0da1fe1;" + "ios=b1f9fe31-39d4-4e12-880e-bdd8e707957e;", typeof(Analytics), typeof(Crashes));
        }

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
