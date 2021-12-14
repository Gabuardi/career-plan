using System;
using CareerPlan.ViewModels;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace CareerPlan.Views
{
    public partial class NewPlanPage : ContentPage
    {
        private NewPlanMV viewModel;

        public NewPlanPage()
        {
            InitializeComponent();
            viewModel = new NewPlanMV();
            BindingContext = viewModel;
        }

        async void Cancel_Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async void Next_Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Console.WriteLine(JsonConvert.SerializeObject(viewModel.NewCareerPlan));
            await Navigation.PushAsync(new ManagePeriodListPage());
        }
     
    }
}
