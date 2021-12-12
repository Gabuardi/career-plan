namespace CareerPlan.ViewModels
{
    public class HomepageVM
    {

        public string CareerPlanName
        {
            get { return App.CurrentCareerPlan.Name; }
        }

        public int CareerPlanProgress
        {
            get { return App.CurrentCareerPlan.Progress; }
        }

        public int RemainingCourses
        {
            get { return App.CurrentCareerPlan.RemainingCourses; }
        }

        public int RemainingMonths
        {
            get { return App.CurrentCareerPlan.RemainingMonths; }
        }

    }
}

