using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CareerPlan.Views;

namespace CareerPlan
{
    public partial class App : Application
    {
        public App()
        {
            string licenseKey = "NTQ2Njc4QDMxMzkyZTMzMmUzMEtIQ0FoSE1aSGhqWW8wV2RpdWJFRU5yaXdRZDk2YXhiMFpWUDBwZHlhZkE9";
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(licenseKey);

            InitializeComponent();
            MainPage = new NavigationPage(new ApplicationNexo());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
