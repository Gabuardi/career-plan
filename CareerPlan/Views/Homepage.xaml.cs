using Xamarin.Forms;

namespace CareerPlan.Views
{
    public partial class Homepage : ContentPage
    {
        public Homepage()
        {
            InitializeComponent();
            BindingContext = AppStorage.CareerPlan;
        }

        async void New_Plan_Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new NewPlanPage());
        }

        async void View_Courses_Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CareerPlanBoard(AppStorage.CareerPlan));
        }
    }
}
