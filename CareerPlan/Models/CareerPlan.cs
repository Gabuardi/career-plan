using System.Collections.Generic;

namespace CareerPlan.Models
{
    public class CareerPlan
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int TotalCredits { get; set; }
        public int TotalCourses { get; set; }
        public double TotalPrice { get; set; }
        public int Progresss { get; set; }
        public int RemainingMonths { get; set; }
        public int RemainingCourses { get; set; }
        public List<Period> PeriodsList { get; set; }
       
    }
}
