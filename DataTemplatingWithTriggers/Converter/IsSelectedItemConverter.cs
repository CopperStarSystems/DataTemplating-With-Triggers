//  --------------------------------------------------------------------------------------
// DataTemplatingWithTriggers.IsSelectedItemConverter.cs
// 2017/07/31
//  --------------------------------------------------------------------------------------

using System;
using System.Globalization;
using System.Windows.Data;

namespace DataTemplatingWithTriggers.Converter
{
    public class IsSelectedItemConverter : IMultiValueConverter
    {
        public object Convert(
            object[] values,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            // See if the first value and the second value are the
            // same object (i.e. same instance, not same type)
            //
            // Note:  ReferenceEquals comes from the Object type.
            return ReferenceEquals(values[0], values[1]);
        }

        // This is a one-way converter, so we just ignore implementing
        // the ConvertBack method.  WPF will not freak out about this.
        public object[] ConvertBack(
            object value,
            Type[] targetTypes,
            object parameter,
            CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}