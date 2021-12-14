using Xamarin.Forms;

namespace CareerPlan.Views
{
    public partial class CareerPlanSummaryPage : ContentPage
    {
        public CareerPlanSummaryPage()
        {
            InitializeComponent();
        }

        async void Edit_Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new NewPlanPage());
        }

        async void Select_Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Homepage());
        }

        async void View_Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CareerPlanBoard());
        }
    }
}
