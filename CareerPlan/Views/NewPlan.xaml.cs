using CareerPlan.ViewModels;
using Xamarin.Forms;

namespace CareerPlan.Views
{
    public partial class NewPlanPage : ContentPage
    {
        public NewPlanPage()
        {
            InitializeComponent();
            BindingContext = new NewPlanMV();
        }

        async void Cancel_Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async void Next_Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ManagePeriodListPage());
        }
     
    }
}
