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

        void GoToHomepage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Homepage());
        }

        void GoToCareerPlanBoard(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CareerPlanBoard());
        }
    }
}
