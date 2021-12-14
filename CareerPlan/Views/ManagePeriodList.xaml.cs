using Xamarin.Forms;
using System.Collections.ObjectModel;
using CareerPlan.Models;

namespace CareerPlan.Views
{
    public partial class ManagePeriodListPage : ContentPage
    {
        ObservableCollection<Period> periods = new ObservableCollection<Period>();

        public ManagePeriodListPage()
        {
            InitializeComponent();

            PeriodsList.ItemsSource = periods;
            periods.Add(new Period { Name="I Cuatrimeste" });
            periods.Add(new Period { Name= "II Cuatrimeste" });
            periods.Add(new Period { Name = "III Cuatrimeste" });
            periods.Add(new Period { Name = "IV Cuatrimeste" });

        }

        public ObservableCollection<Period> Periods { get { return periods; } }

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
