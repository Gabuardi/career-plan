using Xamarin.Forms;
using CareerPlan.Views;
using CareerPlan.ViewModels;
using CareerPlan.Models;
using System.Collections.ObjectModel;

namespace CareerPlan
{
    public partial class App : Application
    {

        public App()
        {
            string licenseKey = "NTQ2Njc4QDMxMzkyZTMzMmUzMEtIQ0FoSE1aSGhqWW8wV2RpdWJFRU5yaXdRZDk2YXhiMFpWUDBwZHlhZkE9";
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(licenseKey);

            InitializeComponent();
            Page InitialPage;
            if (AppStorage.hasCareerPlanStored())
            {
                InitialPage = new Homepage();
            } else {
                InitialPage = new NoPlanPage();
            }
            MainPage = new NavigationPage(InitialPage);

            //AppStorage.CareerPlan = new Models.CareerPlan
            //{
            //    Name = "Bachillerato de Ingeniería en Informática",
            //    Code = "300-033",
            //    Description = "This is a test career plan",
            //    Progress = 58,
            //    RemainingMonths = 16,
            //    RemainingCourses = 17,
            //    PeriodsList = new ObservableCollection<Period> {
            //        new Period {
            //            Name = "I Cuatrimestre",
            //            Months = 4,
            //            CoursesList = new ObservableCollection<Course> {
            //                new Course { Name="Fundamentos de TI",IsLocked=false, IsApproved=true },
            //                new Course { Name="Matematicas Discretas",IsLocked=false, IsApproved=true  },
            //                new Course { Name="Precalculo",IsLocked=false, IsApproved=true },
            //                new Course { Name="Freshman Seminar", IsLocked=false, IsApproved=true },
            //                new Course { Name="Ingles 1", IsLocked=false, IsApproved=true },
            //            }
            //        },
            //        new Period {
            //        Name = "II Cuatrimestre",
            //        Months = 4,
            //        CoursesList = new ObservableCollection<Course> {
            //            new Course { Name="Fundamentos de Programacion", IsLocked=false, IsApproved=true  },
            //            new Course { Name="Introduccion A Electronica", IsLocked=false, IsApproved=true  },
            //            new Course { Name="Calculo I", IsLocked=false, IsApproved=true  },
            //            new Course { Name="Multimedia y la Internet" , IsLocked=false, IsApproved=true},
            //            new Course { Name="Ingles II", IsLocked=false, IsApproved=true },
            //            }
            //        },
            //    new Period {
            //    Name = "III Cuatrimestre",
            //    Months = 4,
            //    CoursesList = new ObservableCollection<Course> {
            //        new Course { Name="Programacion Concurrente", IsLocked=false, IsApproved=true },
            //        new Course { Name="Estructura de datos", IsLocked=false, IsApproved=true },
            //        new Course { Name="Sistemas Operativos", IsLocked=false, IsApproved=true },
            //        new Course { Name="Probabilidad y Estadistica", IsLocked=false, IsApproved=true },
            //        new Course { Name="Ingles III", IsLocked=false, IsApproved=true },
            //    }
            //},
            //    new Period {
            //    Name = "IV Cuatrimestre",
            //    Months = 4,
            //    CoursesList = new ObservableCollection<Course> {
            //        new Course { Name="Diseno de Aplicaciones de Software", IsLocked=false, IsApproved=true },
            //        new Course { Name="Redes", IsLocked=false, IsApproved=true },
            //        new Course { Name="Base de datos", IsLocked=false, IsApproved=true },
            //        new Course { Name="Ingenieria Economica" , IsLocked=false, IsApproved=true},
            //        new Course { Name="Ingles IV", IsLocked=false, IsApproved=true},
            //    }
            //},

            //        new Period {
            //    Name = "V Cuatrimestre",
            //    Months = 2451,
            //    CoursesList = new ObservableCollection<Course> {
            //        new Course { Name="Desarrollo Aplicaciones Web", IsLocked=false },
            //        new Course { Name="Electiva Telematica", IsLocked=false  },
            //        new Course { Name="Analisis, Diseno e implementacion de Sistemas", IsLocked=false, IsApproved=true },
            //        new Course { Name="Lenguaje de Consulta de Base de Datos", IsLocked=true },
            //        new Course { Name="Argumentacion y Retorica", IsLocked=false, IsApproved=true },




            //    }
            //},
            //    new Period {
            //    Name = "VI Cuatrimestre",
            //    Months = 2451,
            //    CoursesList = new ObservableCollection<Course> {
            //        new Course { Name="Servicios Web", IsLocked=true },
            //        new Course { Name="Electiva Programacion", IsLocked=true  },
            //        new Course { Name="Electiva Inteligencia de Negocios", IsLocked=false },
            //        new Course { Name="Razonamiento Moral", IsLocked=false },
            //        new Course { Name="Espresiones del Espiritu Humano", IsLocked=false },




            //    }
            //},
            //    new Period {
            //    Name = "VII Cuatrimestre",
            //    Months = 2451,
            //    CoursesList = new ObservableCollection<Course> {
            //        new Course { Name="Electiva diseno Web", IsLocked=true },
            //        new Course { Name="Electiva Estandares", IsLocked=true  },
            //        new Course { Name="Segurida y Proteccion de Datos", IsLocked=false },
            //        new Course { Name="Experencia Profesional 1", IsLocked=true },
            //        new Course { Name="Globalizacion, Ambiente y Desarrollo Humano", IsLocked=true },




            //    }
            //},
            //    new Period {
            //    Name = "VIII Cuatrimestre",
            //    Months = 2451,
            //    CoursesList = new ObservableCollection<Course> {
            //        new Course { Name="Diseno Medios Dinamicos", IsLocked=true },
            //        new Course { Name="Electiva Bases de Datos", IsLocked=true  },
            //        new Course { Name="Experencia Profesional 2", IsLocked=true },
            //        new Course { Name="Creacion de Empresas"},

            //        new Course { Name="Seminario de Investigacion, Costa Rica y El mundo", IsLocked=true },




            //    }
            //}


            //    }


            //};
            // ========


        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
