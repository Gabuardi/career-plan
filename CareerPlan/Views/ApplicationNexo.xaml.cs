using CareerPlan.views;
using System;
using Xamarin.Forms;

namespace CareerPlan.Views
{
    public partial class ApplicationNexo : ContentPage
    {
        public ApplicationNexo()
        {
            InitializeComponent();
        }

        void GoToNoPlanPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NoPlanPage());
        }

        void GoToNewPlanPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewPlanPage());
        }

        async void GoToManagePeriodListPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ManagePeriodList());
        }

        void GoToStudentPeriod(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewPeriodPage());
        }

        async void GoToNewCoursePage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewCoursePage());
        }

        void GoToCareerPlanSummary(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CareerPlanSummaryPage());
        }
        
        void GoToHomepage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Homepage());
        }
    }
}
