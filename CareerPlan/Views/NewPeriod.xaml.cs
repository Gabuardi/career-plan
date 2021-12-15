using Xamarin.Forms;
using CareerPlan.Models;
using CareerPlan.views;

namespace CareerPlan.Views
{
    public partial class NewPeriodPage : ContentPage
    {

        public NewPeriodPage()
        {
            InitializeComponent();
            AppStorage.TempPeriod = new Period();
            BindingContext = AppStorage.TempPeriod;
        }

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
            Period newPeriod = AppStorage.TempPeriod;
            AppStorage.TempCareerPlan.RemainingMonths += newPeriod.Months;
            foreach (Course course in newPeriod.CoursesList)
            {
                AppStorage.TempCareerPlan.RemainingCourses += 1;
                AppStorage.TempCareerPlan.TotalPrice += course.Price;
                AppStorage.TempCareerPlan.TotalCredits += course.Credits;
            }
            AppStorage.TempCareerPlan.PeriodsList.Add(newPeriod);
            await Navigation.PopAsync();
        }
    }
}
