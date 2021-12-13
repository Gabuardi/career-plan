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

        readonly ObservableCollection<Course> searchResults = new ObservableCollection<Course>
        {
            new Course { Name="Inglés IV" },
            new Course { Name="Matemáticas Discretas" },
            new Course { Name="Xamarin"}
        }; 

        public NewCoursePage()
        {
            InitializeComponent();

            PeriodsList.ItemsSource = periods;
            periods.Add(new Period { Name="I Cuatrimeste" });
            periods.Add(new Period { Name = "II Cuatrimeste" });
            periods.Add(new Period { Name = "III Cuatrimeste" });
            periods.Add(new Period { Name = "IV Cuatrimeste" });

            SearchResultsListView.ItemsSource = searchResults;
        }

        void SearchBar_Focused(System.Object sender, Xamarin.Forms.FocusEventArgs e)
        {
            PeriodsList.IsVisible = false;
            SearchResultsPanel.IsVisible = true;
        }

        void SearchBar_Unfocused(System.Object sender, Xamarin.Forms.FocusEventArgs e)
        {
            SearchResultsPanel.IsVisible = false;
            PeriodsList.IsVisible = true;
        }
    }
}