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
            periods.Add(new Period { Title="I Cuatrimeste" });
            periods.Add(new Period { Title= "II Cuatrimeste" });
            periods.Add(new Period { Title = "III Cuatrimeste" });
            periods.Add(new Period { Title = "IV Cuatrimeste" });

        }

        public ObservableCollection<Period> Periods { get { return periods; } }

    }
}
