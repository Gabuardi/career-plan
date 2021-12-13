using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CareerPlan.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CareerPlan.views
{
    public partial class NewCoursePage : ContentPage
    {
        readonly ObservableCollection<Period> periods = new ObservableCollection<Period>();

        public NewCoursePage()
        {
            InitializeComponent();

            PeriodsList.ItemsSource = periods;
            periods.Add(new Period { Title="I Cuatrimeste" });
            periods.Add(new Period { Title= "II Cuatrimeste" });
            periods.Add(new Period { Title = "III Cuatrimeste" });
            periods.Add(new Period { Title = "IV Cuatrimeste" });
        }

    }
}