using System.Collections.ObjectModel;
using CareerPlan.Models;
using Xamarin.Forms;

namespace CareerPlan.Views
{
    public partial class ManagePeriodListPage : ContentPage
    {

        public ManagePeriodListPage()
        {
            InitializeComponent();
            BindingContext = AppStorage.TempCareerPlan;
        }

        async void Add_Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new NewPeriodPage());
        }

        async void Edit_Course_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new NewPeriodPage());
        }

        void Done_Button_Clicked(System.Object sender, System.EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new CareerPlanSummaryPage());
        }
       
    }
}
