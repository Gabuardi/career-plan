namespace CareerPlan.ViewModels
{
    public class HomepageVM
    {
        private readonly Models.CareerPlan currentCareerPlan = AppStorage.CareerPlan;

        public string CareerPlanName
        {
            get { return currentCareerPlan.Name; }
        }

        public int CareerPlanProgress
        {
            get { return currentCareerPlan.Progress; }
        }

        public int RemainingCourses
        {
            get { return currentCareerPlan.RemainingCourses; }
        }

        public int RemainingMonths
        {
            get { return currentCareerPlan.RemainingMonths; }
        }

    }
}

