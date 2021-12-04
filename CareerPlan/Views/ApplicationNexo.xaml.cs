﻿using System;
using System.Collections.Generic;

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
    }
}