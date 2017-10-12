using MvvmCross.Platform.Converters;
using System;
using System.Globalization;

namespace Rosee.Core.Converters
{
    // This converter just returns the same string back.
    // Used for things like custom bindings, like my StyleTextViewBinding.

    public class StringValueConverter : IMvxValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return parameter;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return parameter;
        }
    }
}
