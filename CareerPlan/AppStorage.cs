using Newtonsoft.Json;
using Xamarin.Essentials;

namespace CareerPlan
{
    public static class AppStorage
    {
        readonly private static string careerPlanPreferenceName = "StoredCareerPlan";

        public static Models.CareerPlan CareerPlan
        {
            set
            {
                string serializedValue = JsonConvert.SerializeObject(value);
                Preferences.Set(careerPlanPreferenceName, serializedValue);
            }
            get
            {
                string serializedValue = Preferences.Get(careerPlanPreferenceName, "null");
                Models.CareerPlan storedCareerPlan = JsonConvert.DeserializeObject<Models.CareerPlan>(serializedValue);
                return storedCareerPlan ?? new Models.CareerPlan();
            }
        } 

        public static bool hasCareerPlanStored()
        {
            return Preferences.ContainsKey(careerPlanPreferenceName);
        }

    }
}
