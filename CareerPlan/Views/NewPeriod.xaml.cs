using Xamarin.Forms;
using System.Collections.ObjectModel;
using CareerPlan.Models;
using CareerPlan.views;

namespace CareerPlan.Views
{
    public partial class NewPeriodPage : ContentPage
    {
        ObservableCollection<Period> Studentperiods = new ObservableCollection<Period>();

        public NewPeriodPage()
        {
            InitializeComponent();

            StudentPeriodList.ItemsSource = Studentperiods;
            Studentperiods.Add(new Period { Name = "Fundamentos de Programación" });
            Studentperiods.Add(new Period { Name = "Matemáticas Discretas" });
        }

        public ObservableCollection<Period> StudentPeriods { get { return Studentperiods; } }

        void Add_Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new NewCoursePage());
        }

        void Edit_Course_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new NewPeriodPage());
        }

        void Done_Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
