using Xamarin.Forms;
using CareerPlan.Views;

namespace CareerPlan
{
    public partial class App : Application
    {
        public static Models.CareerPlan CurrentCareerPlan;

        public App()
        {
            string licenseKey = "NTQ2Njc4QDMxMzkyZTMzMmUzMEtIQ0FoSE1aSGhqWW8wV2RpdWJFRU5yaXdRZDk2YXhiMFpWUDBwZHlhZkE9";
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(licenseKey);

            InitializeComponent();
            MainPage = new NavigationPage(new ApplicationNexo());

            CurrentCareerPlan = new Models.CareerPlan
            {
                Name="Testing Career Plan",
                Code="T00-000",
                Description="This is a test career plan",
            };
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
