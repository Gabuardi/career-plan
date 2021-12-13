using Xamarin.Forms;
using System.Collections.ObjectModel;
using CareerPlan.Models;

namespace CareerPlan.Views
{
    public partial class StudentPeriodPage : ContentPage
    {
        ObservableCollection<Period> Studentperiods = new ObservableCollection<Period>();

        public StudentPeriodPage()
        {
            InitializeComponent();

            StudentPeriodList.ItemsSource = Studentperiods;
            Studentperiods.Add(new Period { Name = "Fundamentos de Programación" });
            Studentperiods.Add(new Period { Name = "Matemáticas Discretas" });


        }

        public ObservableCollection<Period> StudentPeriods { get { return Studentperiods; } }

    }
}
