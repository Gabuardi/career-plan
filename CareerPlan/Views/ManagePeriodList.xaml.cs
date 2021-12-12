using Xamarin.Forms;
using System.Collections.ObjectModel;
using CareerPlan.Models;

namespace CareerPlan.Views
{
    public partial class ManagePeriodList : ContentPage
    {
        ObservableCollection<Period> periods = new ObservableCollection<Period>();

        public ManagePeriodList()
        {
            InitializeComponent();

            PeriodsList.ItemsSource = periods;
            periods.Add(new Period { Name="I Cuatrimeste" });
            periods.Add(new Period { Name= "II Cuatrimeste" });
            periods.Add(new Period { Name = "III Cuatrimeste" });
            periods.Add(new Period { Name = "IV Cuatrimeste" });

        }

        public ObservableCollection<Period> Periods { get { return periods; } }

    }
}
