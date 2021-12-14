﻿using CareerPlan.ViewModels;
using Xamarin.Forms;

namespace CareerPlan.Views
{
    public partial class CareerPlanBoard : ContentPage
    {
        public CareerPlanBoard()
        {
            InitializeComponent();
            BindingContext = new CareerPlanBoardVM();
        }
    }
}
