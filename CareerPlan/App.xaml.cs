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
