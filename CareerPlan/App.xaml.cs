﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CareerPlan
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NewPlanPage();
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
