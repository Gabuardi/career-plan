using Xamarin.Forms;

namespace CareerPlan.Views
{
    public partial class CareerPlanBoard : ContentPage
    {
        public CareerPlanBoard(Models.CareerPlan careerPlan)
        {
            InitializeComponent();
            BindingContext = careerPlan;
        }
    }
}
