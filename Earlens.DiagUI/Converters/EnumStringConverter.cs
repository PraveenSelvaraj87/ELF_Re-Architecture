using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Earlens.ETUI.Converters
{
    public class EnumStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            KeyValuePair<int, string> selectedItem = (KeyValuePair<int, string>)value;
            return Enum.ToObject(targetType, selectedItem.Key);
        }
    }
}
