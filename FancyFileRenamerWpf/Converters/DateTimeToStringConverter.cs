using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace FancyFileRenamerWpf.Converters
{
  public class DateTimeToStringConverter : IValueConverter
  {
    #region IValueConverter Members

    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
      if (value is DateTime?)
      {
        DateTime? date = value.As<DateTime?>();

        if (date.HasValue)
          return date.Value.ToString("u");
      }

      return "<empty>";
    }

    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
      throw new NotImplementedException();
    }

    #endregion
  }
}
