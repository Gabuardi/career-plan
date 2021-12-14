using Xamarin.Forms;
using CareerPlan.Models;
using CareerPlan.views;

namespace CareerPlan.Views
{
    public partial class NewPeriodPage : ContentPage
    {
        private Period newPeriod = new Period();

        public NewPeriodPage()
        {
            InitializeComponent();
            BindingContext = newPeriod;
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
            AppStorage.TempCareerPlan.PeriodsList.Add(newPeriod);
            await Navigation.PopAsync();
        }
    }
}
