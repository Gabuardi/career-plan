using Xamarin.Forms;
using CareerPlan.Models;
using CareerPlan.views;

namespace CareerPlan.Views
{
    public partial class NewPeriodPage : ContentPage
    {

        public NewPeriodPage()
        {
            InitializeComponent();
            AppStorage.TempPeriod = new Period();
            BindingContext = AppStorage.TempPeriod;
        }

        async void Add_Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new NewCoursePage());
        }

        async void Edit_Course_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new NewPeriodPage());
        }

        async void Done_Button_Clicked(System.Object sender, System.EventArgs e)
        {
            AppStorage.TempCareerPlan.PeriodsList.Add(AppStorage.TempPeriod);
            await Navigation.PopAsync();
        }
    }
}
