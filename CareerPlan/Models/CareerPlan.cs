using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace CareerPlan.Models
{
    public class CareerPlan
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int TotalCredits { get; set; }
        public double TotalPrice { get; set; }
        public int Progress { get; set; }
        public int RemainingMonths { get; set; }
        public int RemainingCourses { get; set; }
        public ObservableCollection<Period> PeriodsList { get; set; } = new ObservableCollection<Period>();
    }
}
