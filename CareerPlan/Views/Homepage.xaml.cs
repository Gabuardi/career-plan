using CareerPlan.ViewModels;
using Xamarin.Forms;

namespace CareerPlan.Views
{
    public partial class Homepage : ContentPage
    {
        public Homepage()
        {
            InitializeComponent();
            BindingContext = new HomepageVM();
        }
    }
}
