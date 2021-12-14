﻿using System.Collections.Generic;
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
                CoursesList = new List<Course> {
                    new Course { Name = "Ciencias" },
                    new Course { Name="Expresiones del Espiritu Humanoide", IsLocked=false},
                    new Course { Name="Matematicas diabolicas", IsLocked=false, IsApproved=true}
                }
            },
            new Period {
                Name = "Hell",
                Months = 2451,
                CoursesList = new List<Course> {
                    new Course { Name="Lammas Infernales", IsApproved=true, IsLocked=false },
                    new Course { Name="Torturación IV", IsLocked=true }
                }
            }
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
