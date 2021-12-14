using System.Collections.Generic;
using System.Collections.ObjectModel;
using CareerPlan.Models;

namespace CareerPlan.ViewModels
{
    public class CareerPlanBoardVM
    {
        private ObservableCollection<Period> periodsList = new ObservableCollection<Period>
        {
            new Period {
                Name = "Terra",
                Months = 720,
                CoursesList = new ObservableCollection<Course> {
                    new Course { Name = "Ciencias" },
                    new Course { Name="Expresiones del Espiritu Humanoide", IsLocked=false},
                    new Course { Name="Matematicas diabolicas", IsLocked=false, IsApproved=true},
                    new Course { Name="Matematicas diabolicas", IsLocked=false, IsApproved=true},
                    new Course { Name="Matematicas diabolicas", IsLocked=false, IsApproved=true},
                    new Course { Name="Matematicas diabolicas", IsLocked=false, IsApproved=true},
                    new Course { Name="Matematicas diabolicas", IsLocked=false, IsApproved=true},
                    new Course { Name="Matematicas diabolicas", IsLocked=false, IsApproved=true}
                }
            },
            new Period {
                Name = "Hell",
                Months = 2451,
                CoursesList = new ObservableCollection<Course> {
                    new Course { Name="Lammas Infernales", IsApproved=true, IsLocked=false },
                    new Course { Name="Torturación IV", IsLocked=true }
                }
            },
            new Period {
                Name = "Heaven",
                Months = 2451,
                CoursesList = new ObservableCollection<Course> {
                    new Course { Name="Lammas Celestiales", IsLocked=true },
                    new Course { Name="Evalacion V", IsLocked=true }
                }
            }
        };

        public ObservableCollection<Period> PeriodsList
        {
            get { return periodsList; }
        }

        public string Title
        { get { return "Ingeniería Biotecnologíca Cuantica Australiana Con Especialidad En Canguros"; } }

    }
}
