using System;
using System.Collections.Generic;
using System.Globalization;
using CareerPlan.Models;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace CareerPlan.Converter
{
    public class ColorAlternator : IValueConverter
    {

        private static bool isEven = false;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool currentValue = isEven;
            isEven = !isEven;
            return currentValue ? Color.FromHex("#FFF") : Color.FromHex("#EBEBEB");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
