using Xamarin.Forms;
using System.Collections.ObjectModel;
using CareerPlan.Models;
using CareerPlan.views;
using System;
using Newtonsoft.Json;

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
            //Console.WriteLine(JsonConvert.SerializeObject(BindingContext));
            AppStorage.TempCareerPlan.PeriodsList.Add(new Period { Name="XXXXX" });
            await Navigation.PopAsync();
        }
    }
}
