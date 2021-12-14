using System.Collections.Generic;
using System.Collections.ObjectModel;
using CareerPlan.Models;

namespace CareerPlan.ViewModels
{
    public class CareerPlanBoardVM
    {
        private ObservableCollection<Period> periodsList = new ObservableCollection<Period>
        {
            new Period { Name = "Terra", Months = 720 },
            new Period{ Name="Purgatory", Months=80},
            new Period{ Name="Hell", Months=2160},
            new Period{ Name="Heaven", Months=1}
        };
        private bool isColumnsEven = false;

        public ObservableCollection<Period> PeriodsList
        {
            get { return periodsList; }
        }

        public bool IsColumnsEven
        {
            get
            {
                bool currentValue = isColumnsEven;
                isColumnsEven = !currentValue;
                return currentValue;
            }
        }

    }
}
