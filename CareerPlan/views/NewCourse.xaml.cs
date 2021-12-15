using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CareerPlan.Models;
using CareerPlan.Views;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace CareerPlan.views
{
    public partial class NewCoursePage : ContentPage
    {
        private readonly ObservableCollection<Course> searchSource = new ObservableCollection<Course>();
        private Course newCourse = new Course();

        public NewCoursePage()
        {
            InitializeComponent();
            BindingContext = newCourse;
            FillSearchSource();
            SearchResultsListView.ItemsSource = searchSource;
        }

        private void FillSearchSource()
        {
            ObservableCollection<Period> currentPeriodList = AppStorage.TempCareerPlan.PeriodsList;
            foreach (Period period in currentPeriodList)
            {
                foreach (Course course in period.CoursesList) searchSource.Add(course);
            }
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
            newCourse.RequiredCourses.Add(selectedCourse);
        }

        async void Done_Button_Clicked(System.Object sender, System.EventArgs e)
        {
            AppStorage.TempPeriod.CoursesList.Add(newCourse);
            await Navigation.PopAsync();
        }
    }
}