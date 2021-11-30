using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CareerPlan
{
    public partial class NoPlanPage : ContentPage
    {
        public NoPlanPage()
        {
            InitializeComponent();
        }
        private void btnAnadirConID_Clicked(object sender, EventArgs e)
        {

            DisplayPromptAsync("Ingresa el ID del Plan que desea anadir", "", "OK", "Cancel", "ID", -1, null, "");


        }
    }
}
