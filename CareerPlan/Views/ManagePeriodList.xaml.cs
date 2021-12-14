using Xamarin.Forms;
using CareerPlan.ViewModels;

namespace CareerPlan.Views
{
    public partial class ManagePeriodListPage : ContentPage
    {
        private readonly ManagePeriodListVM viewModel;

        public ManagePeriodListPage(Models.CareerPlan newCareerPlan)
        {
            InitializeComponent();
            viewModel = new ManagePeriodListVM(newCareerPlan);
            BindingContext = viewModel;
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
            Application.Current.MainPage = new NavigationPage(new CareerPlanSummaryPage());
        }
       
    }
}
