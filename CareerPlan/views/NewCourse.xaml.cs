using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CareerPlan.Models;
using Xamarin.Forms;

namespace CareerPlan.views
{
    public partial class NewCoursePage : ContentPage
    {
        readonly ObservableCollection<Course> periods = new ObservableCollection<Course>();

        readonly ObservableCollection<Course> searchSource = new ObservableCollection<Course>
        {
            new Course { Name="Inglés IV" },
            new Course { Name="Matemáticas Discretas" },
            new Course { Name="Xamarin"}
        };

        private Course newCourse = new Course();

        public NewCoursePage()
        {
            InitializeComponent();
            BindingContext = newCourse;

            PeriodsList.ItemsSource = periods;
            periods.Add(new Course { Name="I Cuatrimeste" });
            periods.Add(new Course { Name = "II Cuatrimeste" });
            periods.Add(new Course { Name = "III Cuatrimeste" });
            periods.Add(new Course { Name = "IV Cuatrimeste" });
            SearchResultsListView.ItemsSource = searchSource;
        }

        List<Course> SearchCourse(String searchQuery)
        {
            string lowerCaseSearchQuery = searchQuery.ToLower();
            List<Course> searchResults = new List<Course>();

            foreach (Course course in searchSource)
            {
                if (course.Name.ToLower().Contains(lowerCaseSearchQuery))
                { searchResults.Add(course); }
            }
            return searchResults;
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

        void SearchBar_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            SearchBar searchBar = (SearchBar)sender;
            SearchResultsListView.ItemsSource = SearchCourse(searchBar.Text);
        }

        void SearchResultsListView_ItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            Course selectedCourse = (Course)e.Item;
            searchSource.Remove(selectedCourse);
            periods.Add(selectedCourse);
        }

        async void Done_Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}