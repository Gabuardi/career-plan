using System.Collections.ObjectModel;

namespace CareerPlan.Models
{
    public class Course
    {
        public string Name { get; set; }
        public string ProfessorName { get; set; }
        public int Credits { get; set; }
        public double Price { get; set; }
        public bool IsApproved { get; set; }
        public bool IsLocked { get; set; } = true;
        public ObservableCollection<Course> RequiredCourses { get; set; } = new ObservableCollection<Course>();
    }
}
