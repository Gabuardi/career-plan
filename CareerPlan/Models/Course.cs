using System.Collections.ObjectModel;

namespace CareerPlan.Models
{
    public class Course
    {
        public string Name { get; set; }
        public string ProfesorName { get; set; }
        public int Credits { get; set; }
        public double Price { get; set; }
        public ObservableCollection<Course> RequiredCourses { get; set; }
       
    }
}
