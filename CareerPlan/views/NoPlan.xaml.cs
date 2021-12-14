using Xamarin.Forms;

namespace CareerPlan.Views
{
    public partial class NoPlanPage : ContentPage
    {
        public NoPlanPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new NewPlanPage());
        }
    }
}
