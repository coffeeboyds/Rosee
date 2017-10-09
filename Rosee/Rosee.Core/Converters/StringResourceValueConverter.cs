using System;
using System.Globalization;
using MvvmCross.Platform.Converters;
using Rosee.Core.ViewModels;

namespace Rosee.Core.Converters
{
    public class StringResourceValueConverter : IMvxValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return BaseViewModelUtility.StringLookup((string)parameter);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
