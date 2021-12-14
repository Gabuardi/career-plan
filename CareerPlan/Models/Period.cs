using System.Collections.ObjectModel;

namespace CareerPlan.Models
{
    public class Period
    {
        public string Name { get; set; }
        public int Months { get; set; }
        public ObservableCollection<Course> CoursesList { get; set; } = new ObservableCollection<Course>();
    }
}
