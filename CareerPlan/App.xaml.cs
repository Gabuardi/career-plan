using Xamarin.Forms;
using CareerPlan.Views;
using CareerPlan.ViewModels;

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
           
            //AppStorage.CareerPlan = new Models.CareerPlan
            //{
            //    Name = "Testing Career Plan",
            //    Code = "T00-000",
            //    Description = "This is a test career plan",
            //    Progress = 18,
            //    RemainingMonths = 56,
            //    RemainingCourses = 128
            //};
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
