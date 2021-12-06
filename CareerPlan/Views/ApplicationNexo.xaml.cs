﻿using System;
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
    }
}