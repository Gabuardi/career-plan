using System.Collections.Generic;
using CareerPlan.Models;

namespace CareerPlan.ViewModels
{
    public class CareerPlanBoardVM
    {
        readonly private List<Period> periodsList = new List<Period>
        {
            new Period{ Name="Terra", Months=720 },
            new Period{ Name="Purgatory", Months=80},
            new Period{ Name="Hell", Months=2160},
            new Period{ Name="Heaven", Months=1}
        };

        List<Period> PeriodsList
        {
            get { return periodsList; }
        }
    }
}
