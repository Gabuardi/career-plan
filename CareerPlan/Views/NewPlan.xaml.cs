using Xamarin.Forms;

namespace CareerPlan.Views
{
    public partial class NewPlanPage : ContentPage
    {

        public NewPlanPage()
        {
            InitializeComponent();
            BindingContext = AppStorage.TempCareerPlan;
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
