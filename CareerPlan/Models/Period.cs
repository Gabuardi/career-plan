using System.Collections.Generic;

namespace CareerPlan.Models
{
    public class Period
    {
        public string Name { get; set; }
        public int Months { get; set; }
        public List<Course> CoursesList { get; set; }

    }
}
