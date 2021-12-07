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

        void GoToManagePeriodListPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ManagePeriodList());
        }

        void GoToStudentPeriod(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StudentPeriodPage());
        }
        
        void GoToNewCoursePage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewCoursePage());
        }
        
    }
}
