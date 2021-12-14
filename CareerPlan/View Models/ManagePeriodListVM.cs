namespace CareerPlan.ViewModels
{
    public class ManagePeriodListVM
    {
        private Models.CareerPlan newCareerPlan;

        public ManagePeriodListVM(Models.CareerPlan newCareerPlan)
        {
            this.newCareerPlan = newCareerPlan;
        }

        public Models.CareerPlan NewCareerPlan
        {
            get { return newCareerPlan; }
        }

    }
}
